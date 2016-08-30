using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IAdditionalMealService : IService<AdditionalMealDTO>
    {
        [OperationContract]
        AdditionalMealDTO GetLastAdditionalMealByHospId(int hospId);

        [OperationContract]
        IEnumerable<AdditionalMealDTO> GetAdditionalMealsByOrderDate(DateTime orderDate);
    }
}
