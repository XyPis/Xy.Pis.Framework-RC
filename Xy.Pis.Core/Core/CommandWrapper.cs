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

        public void Execute(Action<IUnitOfWork> work, TransactionOption option = TransactionOption.Default)
        {
            if (work == null)
                throw new ArgumentNullException("work");

            if (option == TransactionOption.Default)
                DoAction(work);
            else if (option == TransactionOption.Database)
                DoActionWithDatabaseTx(work);
            else if (option == TransactionOption.Distributed)
                DoActionWithDistributedTx(work);
            else
                throw new ArgumentOutOfRangeException("option");
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> work, TransactionOption option = TransactionOption.Default)
        {
            if (option == TransactionOption.Default)
                return DoFunction(work);
            else if (option == TransactionOption.Database)
                return DoFunctionWithDatabaseTx(work);
            else if (option == TransactionOption.Distributed)
                return DoFunctionWithDistributedTx(work);
            else
                throw new ArgumentOutOfRangeException("option");
        }

        private void DoAction(Action<IUnitOfWork> work)
        {
            using (var uow = UnitOfWork)
            {
                work(uow);
                uow.SaveChanges();
            }
        }

        private void DoActionWithDatabaseTx(Action<IUnitOfWork> work)
        {
            using (var uow = UnitOfWork)
            {
                var db = uow.EFContext.Database;
                using (var tx = db.BeginTransaction())
                {
                    try
                    {
                        work(uow);
                        uow.SaveChanges();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        if (ex != null)
                        {
                            Log.ErrorFormat("Exception: {0} \n{1}", ex.Message, ex.StackTrace);
                            if (ex.InnerException != null)
                                Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
                        }

                        throw;
                    }
                }
            }
        }

        private void DoActionWithDistributedTx(Action<IUnitOfWork> work)
        {
            using (var uow = UnitOfWork)
            {                
                using (var tx = new TransactionScope())
                {
                    try
                    {
                        work(uow);
                        uow.SaveChanges();
                        tx.Complete();
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
                }
            }
        }        

        private TResult DoFunction<TResult>(Func<IUnitOfWork, TResult> work)
        {
            TResult result = default(TResult);

            using (var uow = UnitOfWork)
            {
                result = work(uow);
                uow.SaveChanges();
            }

            return result;
        }

        private TResult DoFunctionWithDatabaseTx<TResult>(Func<IUnitOfWork, TResult> work)
        {
            TResult result = default(TResult);

            using (var uow = UnitOfWork)
            {
                var db = uow.EFContext.Database;
                using (var tx = db.BeginTransaction())
                {
                    try
                    {
                        result = work(uow);
                        uow.SaveChanges();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
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
                        tx.Dispose();
                        uow.Dispose();                        
                    }
                }
            }

            return result;
        }

        private TResult DoFunctionWithDistributedTx<TResult>(Func<IUnitOfWork, TResult> work)
        {
            TResult result = default(TResult);

            using (var uow = UnitOfWork)
            {
                using (var tx = new TransactionScope())
                {
                    try
                    {
                        result = work(uow);
                        uow.SaveChanges();
                        tx.Complete();                        
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
                        tx.Dispose();                        
                    }
                }
            }

            return result;
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
