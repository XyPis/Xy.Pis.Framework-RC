using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class EngineeringMaintenanceService : AbstractService<LmWorkRepair, EngineeringMaintenanceDTO>, IEngineeringMaintenanceService
    {
        public virtual IEnumerable<EngineeringMaintenanceDTO> FullTextSearch(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Searching text can not be null or empty", "text");
            }                

            Expression<Func<LmWorkRepair, bool>> predicate = x => x.Name.Contains(text) || x.Position.Contains(text) || x.Memo.Contains(text);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    return uow.Get<LmWorkRepair>()
                        .Where(predicate)                        
                        .MapTo<EngineeringMaintenanceDTO>();
                });
            }
        }
    }
}
