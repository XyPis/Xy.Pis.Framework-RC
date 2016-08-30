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
    public class StopMealRegisterationService : AbstractService<InStopMealRegister, StopMealRegisterationDTO>, IStopMealRegisterationService
    {
        public virtual IEnumerable<StopMealRegisterationDTO> QueryByLocationAndDateRange(DateTime startDate, DateTime endDate, int locationId = 0)
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    var query = uow.Get<InStopMealRegister>();
                    if (locationId > 0)
                    {
                        query = query.Where(x => x.LocationID == locationId);
                    }                        
                    
                    query = query.Where(x => x.OperTime >= startDate && x.OperTime <= endDate);

                    return query.MapTo<StopMealRegisterationDTO>();
                });
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<InStopMealRegister, StopMealRegisterationDTO>()
                .ForMember(dest => dest.CancelQty, opt => opt.MapFrom(src => src.StopMealCount))
                .ForMember(dest => dest.OrderQty, opt => opt.MapFrom(src => src.OrderMealsCount));

            Mapper.CreateMap<StopMealRegisterationDTO, InStopMealRegister>()
                .ForMember(dest => dest.OrderMealsCount, opt => opt.MapFrom(src => src.OrderQty))
                .ForMember(dest => dest.StopMealCount, opt => opt.MapFrom(src => src.CancelQty));
        }
    }
}
