using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;
using AutoMapper;

namespace Xy.Pis.Service.Logistics
{
    public class StopMealRegisterationService : UoWService<InStopMealRegister, StopMealRegisterationDTO>, IStopMealRegisterationService
    {
        protected override void Configure()
        {
            Mapper.CreateMap<InStopMealRegister, StopMealRegisterationDTO>()
                .ForMember(dest => dest.CancelQty, opt => opt.MapFrom(src => src.StopMealCount))
                .ForMember(dest => dest.OrderQty, opt => opt.MapFrom(src => src.OrderMealsCount))
                ;

            Mapper.CreateMap<StopMealRegisterationDTO, InStopMealRegister>()
                .ForMember(dest => dest.OrderMealsCount, opt => opt.MapFrom(src => src.OrderQty))
                .ForMember(dest => dest.StopMealCount, opt => opt.MapFrom(src => src.CancelQty))
                ;
        }
    }
}
