using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IEngineeringMaintenanceService : IService<EngineeringMaintenanceDTO>
    {
        [OperationContract]
        IEnumerable<EngineeringMaintenanceDTO> FullTextSearch(string text);
    }
}
