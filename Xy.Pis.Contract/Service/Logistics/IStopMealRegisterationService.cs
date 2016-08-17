using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IStopMealRegisterationService : IService<StopMealRegisterationDTO>
    {
        IEnumerable<StopMealRegisterationDTO> QueryByLocationAndDateRange(DateTime startDate, DateTime endDate, int locationId = 0);
    }
}
