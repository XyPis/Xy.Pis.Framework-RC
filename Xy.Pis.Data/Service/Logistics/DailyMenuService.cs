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
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.BsItem.PriceIn))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.LsClass))
                ;
        }


        public IEnumerable<FoodDTO> GetMenuListByType(int type)
        {
            
                //return uow.GetLastAdditionalMealByHospId(hospId);
                return null;
            
        }
    }
}
