using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using AutoMapper;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class EngineeringMaintenanceService : UoWService<LmWorkRepair, EngineeringMaintenanceDTO>, IEngineeringMaintenanceService
    {
        protected override void Configure()
        {
            Mapper.CreateMap<LmWorkRepair, EngineeringMaintenanceDTO>()
                .ForMember(dest => dest.FacilityName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ETC, opt => opt.MapFrom(src => src.CompletionBeginTime))
                .ForMember(dest => dest.ATC, opt => opt.MapFrom(src => src.CompletionEndTime))
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Memo))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.LsStatus))                
                .ForMember(dest => dest.ResponsiblityLocId, opt => opt.MapFrom(src => src.RepairLocationId))                
                ;

            Mapper.CreateMap<EngineeringMaintenanceDTO, LmWorkRepair>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FacilityName))
                .ForMember(dest => dest.CompletionBeginTime, opt => opt.MapFrom(src => src.ETC))
                .ForMember(dest => dest.CompletionEndTime, opt => opt.MapFrom(src => src.ATC))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.LocationName))
                .ForMember(dest => dest.Memo, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.LsStatus, opt => opt.MapFrom(src => src.Status))                
                .ForMember(dest => dest.RepairLocationId, opt => opt.MapFrom(src => src.ResponsiblityLocId))
                ;
        }
    }
}
