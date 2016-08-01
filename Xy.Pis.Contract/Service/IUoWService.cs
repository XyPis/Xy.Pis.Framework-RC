using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.ServiceModel;

namespace Xy.Pis.Contract.Service
{
    [ServiceContract]
    public interface IUoWService<TDTO> : IServiceBase
        where TDTO : DTOBase, new()
    {
        [OperationContract]
        TDTO Add(TDTO dto);

        [OperationContract]
        TDTO GetById(object key);

        [OperationContract]
        IList<TDTO> GetAll();

        [OperationContract]
        int Update(TDTO dto);

        [OperationContract]
        int Delete(TDTO dto);

        [OperationContract]
        int AddBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int UpdateBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int DeleteBatch(IEnumerable<TDTO> dtos);

        void BulkInsert(IEnumerable<TDTO> dtos);

        void BulkUpdate(IEnumerable<TDTO> dtos);

        void BulkDelete(IEnumerable<TDTO> dtos);

        IList<TDTO> Get(Expression<Func<TDTO, bool>> queryExpression);

        int Update(Expression<Func<TDTO, bool>> filterExpression, Expression<Func<TDTO, TDTO>> updateExpression);

        int Delete(Expression<Func<TDTO, bool>> queryExpression);
    }
}
