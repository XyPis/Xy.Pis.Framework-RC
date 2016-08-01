using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IAdditionalMealService : IUoWService<AdditionalMealDTO>
    {
        [OperationContract]
        AdditionalMealDTO GetLastAdditionalMealByHospId(int hospId);

        [OperationContract]
        IEnumerable<AdditionalMealDTO> GetAdditionalMealsByOrderDate(DateTime orderDate);
    }
}
