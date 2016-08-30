using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Xy.Pis.Contract.Message.Logistics;

namespace Xy.Pis.Contract.Service.Logistics
{
    [ServiceContract]
    public interface IWeeklyMenuService : IService<WeeklyMenuDTO>
    {
        [OperationContract]
        DateTime GetLastSunday();

        [OperationContract]
        void InsertOrUpdate(WeeklyMenuDTO weeklyMenuDto);

        [OperationContract]
        IEnumerable<WeeklyMenuDTO> GetWeeklyMenu();
    }
}