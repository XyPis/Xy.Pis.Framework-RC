using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Transactions;
using log4net;
using Microsoft.Practices.Unity;

namespace Xy.Pis.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandWrapper : ICommandWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private bool disposed = false;                

        public CommandWrapper(IUnitOfWork uow)
        {
            this.UnitOfWork = uow;
        }
        
        public IUnitOfWork UnitOfWork { get; set; }
       
        public void Execute(Action<IUnitOfWork> work, TransactionOption option = TransactionOption.CTX)
        {
            if (work == null)
            {
                throw new ArgumentException("Work can not be null", "work");
            }                

            Tuple<bool, Exception> result = null;

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.CTX:
                        result = this.DoCommand(work, uow);
                        break;

                    case TransactionOption.DB:
                        result = this.DoDBCommand(work, uow);
                        break;

                    case TransactionOption.DTC:
                        result = this.DoDTCCommand(work, uow);
                        break;

                    default:
                        result = this.DoCommand(work, uow);
                        break;
                }

                if (!result.Item1)
                {
                    Exception ex = result.Item2;

                    Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                    if (ex.InnerException != null)
                    {
                        Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                    }

                    Log.Debug("***********************************************************");
                    throw ex;
                }
            }
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> work, TransactionOption option = TransactionOption.CTX)
        {
            if (work == null)
            {
                throw new ArgumentException("Work can not be null", "work");
            }                

            Tuple<bool, Exception, TResult> result = null;

            using (var uow = this.UnitOfWork)
            {
                switch (option)
                {
                    case TransactionOption.CTX:
                        result = this.DoCommand(work, uow);
                        break;

                    case TransactionOption.DB:
                        result = this.DoDBCommand(work, uow);
                        break;

                    case TransactionOption.DTC:
                        result = this.DoDTCCommand(work, uow);
                        break;

                    default:
                        result = this.DoCommand(work, uow);
                        break;
                }        
            }

            if (!result.Item1)
            {
                Exception ex = result.Item2;

                Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                if (ex.InnerException != null)
                {
                    Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                }

                Log.Debug("------------------------------------------------------------");
                throw ex;
            }

            return result.Item3;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.UnitOfWork.Dispose();
                    this.UnitOfWork = null;
                }
            }

            this.disposed = true;
        }

        private Tuple<bool, Exception> DoCommand(Action<IUnitOfWork> work, IUnitOfWork uow)
        {            
            Exception exception = null;
            bool doneFlag = false;

            try
            {
                work(uow);
                uow.SaveChanges();
                doneFlag = true;
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                uow.Dispose();
            }

            return new Tuple<bool, Exception>(doneFlag, exception);
        }

        private Tuple<bool, Exception> DoDBCommand(Action<IUnitOfWork> work, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;
            using (var tx = db.BeginTransaction())
            {
                var result = this.DoCommand(work, uow);

                if (result.Item1)
                {
                    tx.Commit();
                }
                else
                {
                    tx.Rollback();
                }

                return result;
            }            
        }

        private Tuple<bool, Exception> DoDTCCommand(Action<IUnitOfWork> work, IUnitOfWork uow)
        {
            using (var tx = new TransactionScope())
            {
                var result = this.DoCommand(work, uow);

                if (result.Item1)
                {
                    tx.Complete();
                }                

                return result;
            }            
        }

        private Tuple<bool, Exception, TResult> DoCommand<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        {            
            TResult result = default(TResult);
            Exception exception = null;
            bool doneFlag = false;

            try
            {
                result = work(uow);
                uow.SaveChanges();
                doneFlag = true;
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                uow.Dispose();
            }

            return new Tuple<bool, Exception, TResult>(doneFlag, exception, result);
        }

        private Tuple<bool, Exception, TResult> DoDBCommand<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        {
            var db = uow.EFContext.Database;
            using (var tx = db.BeginTransaction())
            {
                var result = this.DoCommand(work, uow);

                if (result.Item1)
                {
                    tx.Commit();
                }
                else
                {
                    tx.Rollback();
                }

                return result;
            }
        }

        private Tuple<bool, Exception, TResult> DoDTCCommand<TResult>(Func<IUnitOfWork, TResult> work, IUnitOfWork uow)
        { 
            using (var tx = new TransactionScope())
            {
                var result = this.DoCommand(work, uow);
                if (result.Item1) 
                {
                    tx.Complete();
                }                

                return result;
            }
        }
    }
}
