using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.Practices.Unity;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WeeklyMenuService : AbstractService<LmWeekFood, WeeklyMenuDTO>, IWeeklyMenuService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);       

        public DateTime GetLastSunday()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    var query = uow.Get<LmWeekFood>();
                    bool any = query.Any();
                    if (any)
                    {
                        return query.Max(x => x.EndDate);
                    }
                    else
                    {
                        return DateTime.MinValue;
                    }
                });
            }
        }

        public void InsertOrUpdate(WeeklyMenuDTO weeklyMenuDto) 
        {
            using (var command = CommandWrapper)
            {
                command.Execute(uow => 
                {
                    var query = uow.Get<LmWeekFood>();
                    var weeklyMenu = query.Where(x => SqlFunctions.DateDiff("day", x.StartDate, weeklyMenuDto.StartDate) == 0
                        && SqlFunctions.DateDiff("day", x.EndDate, weeklyMenuDto.EndDate) == 0)
                        .AsNoTracking()
                        .FirstOrDefault();

                    if (weeklyMenu != null)
                    {
                        uow.Update<LmWeekFood>(weeklyMenu);
                    }
                    else
                    {
                        uow.Add<LmWeekFood>(weeklyMenu);
                    }
                });
            }        
        }

        public IEnumerable<WeeklyMenuDTO> GetWeeklyMenu() 
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Get<LmWeekFood>()
                        .MapTo<WeeklyMenuDTO>();
                });              
            }            
        }
    }
}
