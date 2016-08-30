using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;

namespace Xy.Pis.Contract.Service
{
    [ServiceContract]
    public interface IService<TDTO> : IServiceBase
        where TDTO : DTOBase, new()
    {
        [OperationContract]
        TDTO Add(TDTO dto);
        
        [OperationContract]
        Tuple<int, int> AddOrUpdate(IEnumerable<TDTO> dtos);

        [OperationContract]
        void Delete(TDTO dto);

        [OperationContract]
        void DeleteById(object key);

        [OperationContract]
        int DeleteAll();

        [OperationContract]
        void Update(TDTO dto);

        [OperationContract]
        TDTO GetById(object key);
       
        [OperationContract]
        IEnumerable<TDTO> GetAll();
        
        [OperationContract]
        int AddBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int DeleteBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int UpdateBatch(IEnumerable<TDTO> dtos);

        // void BulkInsert(IEnumerable<TDTO> dtos);

        // void BulkUpdate(IEnumerable<TDTO> dtos);

        // void BulkDelete(IEnumerable<TDTO> dtos);
        
        // Lambda expression support
        IEnumerable<TDTO> Get(Expression<Func<TDTO, bool>> queryExpression);

        int Update(Expression<Func<TDTO, bool>> filterExpression, Expression<Func<TDTO, TDTO>> updateExpression);

        int Delete(Expression<Func<TDTO, bool>> queryExpression);
    }
}
