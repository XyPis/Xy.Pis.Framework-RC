using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Reflection;
using System.Transactions;
using log4net;

namespace Xy.Pis.Core
{
    public class CommandWrapper : ICommandWrapper
    {
        private bool _disposed = false;
        
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [Dependency]
        public virtual IUnitOfWork UnitOfWork
        {
            get;
            set;
        }

        public void Execute(Action<IUnitOfWork> work, TransactionOption option = TransactionOption.CTX)
        {
            if (work == null)
                throw new ArgumentNullException("work");

            using (var uow = UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.CTX:
                        DoActionWithCTX(work, uow);
                        break;

                    case TransactionOption.DB:
                        DoActionWithDB(work, uow);
                        break;

                    case TransactionOption.DTC:
                        DoActionWithDTC(work, uow);
                        break;

                    default:
                        DoActionWithCTX(work, uow);
                        break;
                }
            }           
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> work, TransactionOption option = TransactionOption.CTX)
        {
            if (work == null)
                throw new ArgumentNullException("work");

            using (var uow = UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.CTX:
                        return DoFunctionWithCTX(work, uow).Item2;

                    case TransactionOption.DB:
                        return DoFunctionWithDB(work, uow);

                    case TransactionOption.DTC:
                        return DoFunctionWithDTC(work, uow);

                    default:
                        return DoFunctionWithCTX(work, uow).Item2;
                }          
            }          
        }

        private bool DoActionWithCTX(Action<IUnitOfWork> work, IUnitOfWork uow)
        {
            bool flag = false;
            try             
            {
                work(uow);
                uow.SaveChanges();
                flag = true;
            }
            catch(Exception ex)
            {
                if (ex != null)
                {
                    Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                    if (ex.InnerException != null)
                        Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                }

                throw;
            }
            finally
            {
                uow.Dispose();
            }

            return flag;
        }

        private void DoActionWithDB(Action<IUnitOfWork> work, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;
            using (var tx = db.BeginTransaction())
            {
                bool flag = DoActionWithCTX(work, uow);
                if (flag) tx.Commit();
                else tx.Rollback();                  
            }            
        }

        private void DoActionWithDTC(Action<IUnitOfWork> work, IUnitOfWork uow)
        {
            using (var tx = new TransactionScope())
            {                    
                bool flag = DoActionWithCTX(work, uow);                
                if (flag)  tx.Complete();               
            }            
        }

        private Tuple<bool, TResult> DoFunctionWithCTX<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        {
            bool flag = false;
            
            TResult result = default(TResult);

            try
            {
                result = work(uow);
                uow.SaveChanges();
                flag = true;
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                    if (ex.InnerException != null)
                        Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                }

                throw;
            }
            finally
            {
                uow.Dispose();
            }

            return new Tuple<bool, TResult>(flag, result);
        }

        private TResult DoFunctionWithDB<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        {   
            var db = uow.EFContext.Database;
            using (var tx = db.BeginTransaction())
            {
                var result = DoFunctionWithCTX(work, uow);
                
                if (result.Item1) tx.Commit();
                else tx.Rollback();

                return result.Item2;
            }            
        }

        private TResult DoFunctionWithDTC<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        { 
            using (var tx = new TransactionScope())
            {                         
                var result = DoFunctionWithCTX(work, uow);                  
                if (result.Item1) tx.Complete();

                return result.Item2;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    UnitOfWork.Dispose();
                    UnitOfWork = null;
                }
            }
            
            this._disposed = true;
        }
    }
}
