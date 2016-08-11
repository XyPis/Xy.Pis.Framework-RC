using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandWrapper : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }

        void Execute(Action<IUnitOfWork> work, TransactionOption option = TransactionOption.Default);

        TResult Execute<TResult>(Func<IUnitOfWork, TResult> work, TransactionOption option = TransactionOption.Default);   
    }
}
