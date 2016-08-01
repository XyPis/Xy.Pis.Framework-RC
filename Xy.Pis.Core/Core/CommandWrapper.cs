using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Reflection;
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

        public void Execute(Action<IUnitOfWork> work)
        {
            if (work == null)
                throw new ArgumentNullException("work");
            
            using (var uow = UnitOfWork)
            {    
                work(uow);              
                uow.SaveChanges();
            }
        }
      
        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> work)
        {            
            if (work == null)
                throw new ArgumentNullException("work");

            using (var uow = UnitOfWork)
            {
                //Log.DebugFormat("Type:{0} HashCode:{1}", uow.EFContext.GetType(), uow.EFContext.GetHashCode());
                TResult result = work(uow);
             
                uow.SaveChanges();
             
                return result;
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
