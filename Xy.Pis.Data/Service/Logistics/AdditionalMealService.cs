using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Transactions;
using System.Linq.Expressions;
using EntityFramework.Extensions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Domain;

namespace Xy.Pis.Service.Logistics
{
    public class AdditionalMealService : UoWService<AdditionalMeal, AdditionalMealDTO>, IAdditionalMealService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        #region AutoMapper Configuration
        protected override void Configure()
        {
            Mapper.CreateMap<AdditionalMealDetails, AdditionalMealDetailsDTO>();                                           
            Mapper.CreateMap<AdditionalMealDetailsDTO, AdditionalMealDetails>();

            Mapper.CreateMap<AdditionalMeal, AdditionalMealDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.InHosInfo.Name))
                .ForMember(dest => dest.LocFullName, opt => opt.ResolveUsing<LocFullNameResolver>())
                ;
            Mapper.CreateMap<AdditionalMealDTO, AdditionalMeal>();
        }
        #endregion
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
                        .Where(x => DbFunctions.DiffDays(x.OrderDate, orderDate) == 0)
                        .ProjectTo<AdditionalMealDTO>();
                });
            }
        }

        #region Single Entity Operations
        public override AdditionalMealDTO Add(AdditionalMealDTO dto)
        {
            return base.Add(dto);
        }

        public override int Delete(AdditionalMealDTO dto)
        {
            dto.Validation();

            var additionMealID = dto.Id;

            using (var command = CommandWrapper)
            using (var tx = new TransactionScope())
            {
                int rows = command.Execute(uow =>
                {                  
                    //Remove details first
                    uow.Delete<AdditionalMealDetails>(x => x.AdditionalMealId == additionMealID);
                   
                    return uow.Delete<AdditionalMeal>(x => x.Id == additionMealID);                                        
                });

                tx.Complete();
                tx.Dispose();
                return rows;
            }
        }

        public override int Update(AdditionalMealDTO dto)
        {
            dto.Validation();

            var entity = dto.MapTo<AdditionalMeal>();

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    uow.UpdateBatch<AdditionalMealDetails>(entity.Details);

                    uow.Update<AdditionalMeal>(entity);

                    return Constants.SINGLE_ROW;
                });
            }
        }
        #endregion Single Entity Operations


        #region Batch Entities Operations
        public override int AddBatch(IEnumerable<AdditionalMealDTO> dtos)
        {
            return base.AddBatch(dtos);
        }

        public override int DeleteBatch(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();
            
            var additionalMealIDs = dtos.Select(x => x.Id);

            using (var command = CommandWrapper)
            using (var tx = new TransactionScope())
            {                
                int rows = command.Execute(uow =>
                {
                    uow.Delete<AdditionalMealDetails>(x => additionalMealIDs.Contains(x.AdditionalMealId));
                    return uow.Delete<AdditionalMeal>(x => additionalMealIDs.Contains(x.Id));
                });

                tx.Complete();
                tx.Dispose(); 
                return rows;
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
                //entity.Details.ToList().ForEach(x => x.Food = null);
                //entity.Details.Clear();
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
        #endregion Batch Entities Operations

        #region Bulk Operations
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
                        additionalMeal.Details.ToList()
                            .ForEach(y => 
                            {
                                y.AdditionalMealId = additionalMeal.Id;
                            });
                    }

                    additionalMeals.ToList()
                        .ForEach(x =>
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
            using (var tx = new TransactionScope())
            {                
                command.Execute(uow =>
                {
                    uow.BulkUpdate<AdditionalMealDetails>(additionalMealDetails);

                    uow.BulkUpdate<AdditionalMeal>(additionalMeals);
                });
                tx.Complete();
                tx.Dispose();
            }        
        }

        public override void BulkDelete(IEnumerable<AdditionalMealDTO> dtos)
        {
            dtos.Validation();

            var additionalMeals = dtos.MapTo<AdditionalMeal>();

            List<AdditionalMealDetails> additionalMealDetails = new List<AdditionalMealDetails>();            

            using (var command = CommandWrapper)
            using (var tx = new TransactionScope())
            {
                command.Execute(uow =>
                {
                    additionalMeals.ToList()
                       .ForEach(x =>
                       {
                           additionalMealDetails.AddRange(x.Details);
                       });

                    uow.BulkDelete<AdditionalMealDetails>(additionalMealDetails);
                    uow.BulkDelete<AdditionalMeal>(additionalMeals);
                });
                tx.Complete();
                tx.Dispose();
            }
        }
        #endregion Bulk Operations               

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

    public class LocFullNameResolver : ValueResolver<AdditionalMeal, string>
    {
        protected override string ResolveCore(AdditionalMeal source)
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
