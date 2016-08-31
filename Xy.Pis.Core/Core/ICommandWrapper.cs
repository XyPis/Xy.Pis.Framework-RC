using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Core
{
    public interface ICommandWrapper : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }

        void Execute(Action<IUnitOfWork> work, TransactionOption option = TransactionOption.CTX);

        TResult Execute<TResult>(Func<IUnitOfWork, TResult> work, TransactionOption option = TransactionOption.CTX);   
    }
}
