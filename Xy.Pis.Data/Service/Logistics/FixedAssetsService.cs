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
    public class FixedAssetsService : UoWService<LocationEquipment, FixedAssetsDTO>, IFixedAssetsService
    {
        protected override void Configure()
        {
            Mapper.CreateMap<LocationEquipment, FixedAssetsDTO>()
                .ForMember(dest => dest.UserLocation, opt => opt.MapFrom(src => src.UseLocation))
                .ForMember(dest => dest.ResponsibilityId, opt => opt.MapFrom(src => src.ManageManId))
                .ForMember(dest => dest.PlacementLoc, opt => opt.MapFrom(src => src.StorageLocation))
                .ForMember(dest => dest.PurchaseDate, opt => opt.MapFrom(src => src.BuyInDate))
                .ForMember(dest => dest.Qty, opt => opt.MapFrom(src => src.Num))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.Amount))
                ;

            Mapper.CreateMap<FixedAssetsDTO, LocationEquipment>()
                .ForMember(dest => dest.UseLocation, opt => opt.MapFrom(src => src.UserLocation))
                .ForMember(dest => dest.ManageManId, opt => opt.MapFrom(src => src.ResponsibilityId))
                .ForMember(dest => dest.StorageLocation, opt => opt.MapFrom(src => src.PlacementLoc))
                .ForMember(dest => dest.BuyInDate, opt => opt.MapFrom(src => src.PurchaseDate))
                .ForMember(dest => dest.Num, opt => opt.MapFrom(src => src.Qty))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.TotalAmount))
                ;
        }
    }
}
