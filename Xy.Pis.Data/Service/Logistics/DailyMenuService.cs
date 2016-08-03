using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class DailyMenuService : UoWService<LmFood, FoodDTO>, IDailyMenuService
    {
        protected override void Configure()
        {
            Mapper.CreateMap<FoodDTO, LmFood>();
            Mapper.CreateMap<LmFood, FoodDTO>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.LsClass))
                .ForMember(dest => dest.UnitPrice, opt => opt.ResolveUsing<UnitPriceResolver>())
                //.ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => GetUnitPrice(src)))
                ;
        }

        public IEnumerable<FoodDTO> GetMenuListByType(int type)
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {                 
                    return uow.Get<LmFood>(x => x.LsClass == type)
                        .MapTo<FoodDTO>();
                });
            }
        }

        protected Nullable<decimal> GetUnitPrice(LmFood source)
        {
            Nullable<decimal> unitPrie = null;
            if (source.BsItem != null)
                unitPrie = source.BsItem.PriceIn;

            return unitPrie;
        }
    }

    public class UnitPriceResolver : ValueResolver<LmFood, Nullable<decimal>>
    {
        protected override Nullable<decimal> ResolveCore(LmFood source)
        {
            Nullable<decimal> unitPrice = null;

            if (source.BsItem != null)
                unitPrice = source.BsItem.PriceIn;

            return unitPrice;
        }
    }
}
