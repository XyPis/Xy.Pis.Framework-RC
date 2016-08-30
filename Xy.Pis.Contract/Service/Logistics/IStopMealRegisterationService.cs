using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IStopMealRegisterationService : IService<StopMealRegisterationDTO>
    {
        IEnumerable<StopMealRegisterationDTO> QueryByLocationAndDateRange(DateTime startDate, DateTime endDate, int locationId = 0);
    }
}
