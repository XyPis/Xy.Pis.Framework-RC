using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Transactions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class AdditionalMealService : AbstractService<AdditionalMeal, AdditionalMealDTO>, IAdditionalMealService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);           

        public AdditionalMealDTO GetLastAdditionalMealByHospId(int hospId)
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    return uow.Get<AdditionalMeal>()
                        .Where(x => x.HospId == hospId)
                        .OrderByDescending(x => x.OrderDate)
                        .FirstOrDefault()
                        .MapTo<AdditionalMealDTO>();
                });
            }
        }

        public IEnumerable<AdditionalMealDTO> GetAdditionalMealsByOrderDate(DateTime orderDate)
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Get<AdditionalMeal>()
                        .Where(x => SqlFunctions.DateDiff("day", x.OrderDate, orderDate) == 0)
                        .ProjectTo<AdditionalMealDTO>();
                });
            }
        }

        public override AdditionalMealDTO Add(AdditionalMealDTO dto)
        {
            return base.Add(dto);
        }

        public override void Delete(AdditionalMealDTO dto)
        {
            dto.Validation();

            var additionMealID = dto.ID;

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    // Remove details first
                    uow.Delete<AdditionalMealDetails>(x => x.AdditionalMealId == additionMealID);
                   
                    uow.Delete<AdditionalMeal>(x => x.Id == additionMealID);                                        
                });
            }
        }

        public override void Update(AdditionalMealDTO dto)
        {
            dto.Validation();

            var entity = dto.MapTo<AdditionalMeal>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.UpdateBatch<AdditionalMealDetails>(entity.Details);

                    uow.Update<AdditionalMeal>(entity);
                });
            }
        }

        public override int AddBatch(IEnumerable<AdditionalMealDTO> dtos)
        {
            return base.AddBatch(dtos);
        }

        public override int DeleteBatch(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();
            
            var additionalMealIDs = dtos.Select(x => x.ID);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    uow.Delete<AdditionalMealDetails>(x => additionalMealIDs.Contains(x.AdditionalMealId));
                    return uow.Delete<AdditionalMeal>(x => additionalMealIDs.Contains(x.Id));
                });
            }            
        }

        public override int UpdateBatch(IEnumerable<AdditionalMealDTO> dtos)
        {
            // 更新方式视场景而定: 
            // a) 所有更新实体生成一条更新语句 
            // b) 每个更新实体生成一条更新语句
            dtos.Validation();

            var additionalMeals = dtos.MapTo<AdditionalMeal>();
            var additionalMealDetails = new List<AdditionalMealDetails>();
            
            additionalMeals.ToList().ForEach(entity =>                 
            {
                additionalMealDetails.AddRange(entity.Details);
            });

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {                    
                    uow.UpdateBatch<AdditionalMealDetails>(additionalMealDetails);

                    uow.UpdateBatch<AdditionalMeal>(additionalMeals);

                    return additionalMeals.Count();
                });
            }
        }

        public override void BulkInsert(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();

            var additionalMeals = dtos.MapTo<AdditionalMeal>();

            List<AdditionalMealDetails> additionalMealDetails = new List<AdditionalMealDetails>();            

            using (var command = CommandWrapper)
            using (var tx = new TransactionScope())
            {                             
                command.Execute(uow =>
                {
                    // Insert master table first
                    uow.BulkInsert<AdditionalMeal>(additionalMeals);
                    
                    foreach (var additionalMeal in additionalMeals)
                    {
                        additionalMeal.Details.ToList().ForEach(y =>                             
                        {                                
                            y.AdditionalMealId = additionalMeal.Id;                            
                        });
                    }

                    additionalMeals.ToList().ForEach(x =>                        
                    {                    
                        additionalMealDetails.AddRange(x.Details);                        
                    });

                    uow.BulkInsert<AdditionalMealDetails>(additionalMealDetails);
                });
                
                tx.Complete();
                tx.Dispose();
            }
        }

        public override void BulkUpdate(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();
                    
            var additionalMeals = dtos.MapTo<AdditionalMeal>();
            var additionalMealDetails = new List<AdditionalMealDetails>();

            additionalMeals.ToList().ForEach(entity => 
            {            
                additionalMealDetails.AddRange(entity.Details);             
            });

            using (var command = CommandWrapper)            
            {                
                command.Execute(uow =>
                {
                    uow.BulkUpdate<AdditionalMealDetails>(additionalMealDetails);

                    uow.BulkUpdate<AdditionalMeal>(additionalMeals);
                });              
            }        
        }

        public override void BulkDelete(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();

            var additionalMeals = dtos.MapTo<AdditionalMeal>();

            List<AdditionalMealDetails> additionalMealDetails = new List<AdditionalMealDetails>();            

            using (var command = CommandWrapper)            
            {
                command.Execute(uow =>
                {
                    additionalMeals.ToList().ForEach(x =>                       
                    {                    
                        additionalMealDetails.AddRange(x.Details);                       
                    });

                    uow.BulkDelete<AdditionalMealDetails>(additionalMealDetails);
                    uow.BulkDelete<AdditionalMeal>(additionalMeals);
                });
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AdditionalMealDetails, AdditionalMealDetailsDTO>();
            Mapper.CreateMap<AdditionalMealDetailsDTO, AdditionalMealDetails>();

            Mapper.CreateMap<AdditionalMeal, AdditionalMealDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.InHosInfo.Name))
                .ForMember(dest => dest.LocFullName, opt => opt.ResolveUsing<LocationFullNameResolver>());
            Mapper.CreateMap<AdditionalMealDTO, AdditionalMeal>();
        }

        protected string GetFullLocName(AdditionalMeal source)
        {
            if (source != null)
            {
                InHosInfo hosInfo = source.InHosInfo;
                if (hosInfo != null)
                {
                    BsBed bedInfo = source.InHosInfo.BedInfo;
                    if (bedInfo != null)
                    {
                        return string.Concat(bedInfo.BsBedFloor.Name, bedInfo.RoomNo, "号房", bedInfo.Name, "床");
                    }
                }
            }

            return string.Empty;
        }
    }    
}
