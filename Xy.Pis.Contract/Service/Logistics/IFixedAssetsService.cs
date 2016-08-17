using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IFixedAssetsService : IService<FixedAssetsDTO>
    {
        [OperationContract]
        IEnumerable<FixedAssetsDTO> FullTextSearchByCategory(string text, int category = 0);
    }
}
