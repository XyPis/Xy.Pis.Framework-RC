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
    public class FixedAssetsService : AbstractService<LocationEquipment, FixedAssetsDTO>, IFixedAssetsService
    {
        public virtual IEnumerable<FixedAssetsDTO> FullTextSearchByCategory(string text, int category = 0)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Searching text can not be null or empty", "text");
            }                

            Expression<Func<LocationEquipment, bool>> predicate = x => x.Code.Contains(text)
                || x.Name.Contains(text)
                || x.UseLocation.Contains(text)
                || x.StorageLocation.Contains(text)
                || x.VoucherNo.Contains(text)
                || x.SourcesOfFunds.Contains(text)
                || x.Memo.Contains(text);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    var query = uow.Get<LocationEquipment>();
                    if (category > 0)
                    {
                        query = query.Where(x => x.Type == category);
                    }                        
                    
                    return query.Where(predicate)
                        .MapTo<FixedAssetsDTO>();
                });
            }
        }
    }
}
