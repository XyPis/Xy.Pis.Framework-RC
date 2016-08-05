using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Reflection;
using System.Linq.Expressions;
using AutoMapper;
using log4net;
using System.Transactions;
using Xy.Pis.Domain;
using Xy.Pis.Core;
using Xy.Pis.Contract.Service;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using EntityFramework.Extensions;

namespace Xy.Pis.Service
{
    public abstract class UoWService<TEntity, TDTO> : Profile, IUoWService<TDTO> 
        where TEntity: EntityBase, new()
        where TDTO : DTOBase, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);        

        [Dependency]
        public virtual ICommandWrapper CommandWrapper
        {
            get { return Common.Unity.IoC.Resolve<ICommandWrapper>(); }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TEntity, TDTO>();
            Mapper.CreateMap<TDTO, TEntity>();
        }

        public virtual TDTO Add(TDTO dto)
        {
            dto.Validation();

            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {                
                command.Execute(uow =>
                {
                    uow.Insert<TEntity>(entity);
                });
                
                return entity.MapTo<TDTO>();
            }
        }

        public virtual TDTO GetById(object key) 
        {            
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.GetById<TEntity>(key)
                        .MapTo<TDTO>();
                });
            }
        }
        
        public virtual IList<TDTO> GetAll() 
        {
            using (var command = CommandWrapper)
            {                
                return command.Execute(uow =>
                {                  
                    //return uow.Get<TEntity>().ProjectTo<TDTO>().ToList();
                    return uow.Get<TEntity>().MapTo<TDTO>().ToList();
                });
            }
        }

        public virtual int Update(TDTO dto) 
        {
            dto.Validation();
            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    uow.Update(entity);
                    
                    return Constants.SINGLE_ROW;
                });
            }            
        }

        public virtual int Delete(TDTO dto)
        {
            dto.Validation();
            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {                    
                    uow.Delete(entity);
                    
                    return Constants.SINGLE_ROW;
                });
            }
        }

        public virtual int AddBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    int effectedRows = 0;

                    entities.ToList().ForEach(entity => 
                    {
                        uow.Insert<TEntity>(entity);
                        effectedRows++;
                    });

                    return effectedRows;
                });
            }            
        }

        public virtual int UpdateBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    int effectedRows = 0;

                    entities.ToList().ForEach(entity => 
                    {                    
                        uow.Update<TEntity>(entity);
                        effectedRows++;
                    });

                    return effectedRows;
                });                
            }
        }

        public virtual int DeleteBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>();
            
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    int effectedRows = 0;

                    entities.ToList().ForEach(entity =>
                    {
                        uow.Delete<TEntity>(entity);
                        effectedRows++;
                    });

                    return effectedRows;        
                });
            }
        }

        public virtual void BulkInsert(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {                    
                    uow.BulkInsert<TEntity>(entities);
                });
            }
        }

        public virtual void BulkUpdate(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.BulkUpdate<TEntity>(entities);
                });
            }
        }

        public virtual void BulkDelete(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.BulkDelete<TEntity>(entities);
                });
            }
        }

        public IList<TDTO> Get(Expression<Func<TDTO, bool>> predicate)
        {
            var expression = Mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Get<TEntity>(expression).MapTo<TDTO>().ToList();
                });
            }
        }

        public int Update(Expression<Func<TDTO, bool>> filterExpression, Expression<Func<TDTO, TDTO>> updateExpression)
        {
            var filterExpressionForEntity = Mapper.Map<Expression<Func<TEntity, bool>>>(filterExpression);
            var updateExpressionForEntity = Mapper.Map<Expression<Func<TEntity, TEntity>>>(updateExpression);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Update<TEntity>(filterExpressionForEntity, updateExpressionForEntity);
                });
            }
        }

        public int Delete(Expression<Func<TDTO, bool>> queryExpression)
        {
            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(queryExpression);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Delete<TEntity>(predicate);
                });
            }
        }

        public virtual Tuple<Int32, Int32> AddOrUpdate(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var addedEntities = dtos.Where(x => x.ID == 0).MapTo<TEntity>();
            var updatedEntities = dtos.Where(x => x.ID != 0).MapTo<TEntity>();
            int addedRows = 0;
            int updatedRows = 0;

            using (var command = CommandWrapper)
            {
                command.Execute(uow => 
                {
                    addedEntities.ToList().ForEach(entity =>
                    {
                        uow.Insert(entity);
                        addedRows++;
                    });
                    
                    updatedEntities.ToList().ForEach(entity =>
                    {
                        uow.Update(entity);
                        updatedRows++;
                    }); 
                });

                return new Tuple<int, int>(addedRows, updatedRows);
            }
        }

        public virtual int DeleteAll()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    return uow.DeleteAll<TEntity>();
                });
            }
        }

        public virtual void DeleteById(object key)
        {
            using (var command = CommandWrapper)
            {                
                command.Execute(uow =>
                {                    
                    uow.DeleteById<TEntity>(key);
                });
            }
        }
    }
}
