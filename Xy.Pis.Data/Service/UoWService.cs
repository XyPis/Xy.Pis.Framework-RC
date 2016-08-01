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
                    return uow.Get<TEntity>().ProjectTo<TDTO>().ToList();
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
                command.Execute(uow => 
                {
                    entities.ToList().ForEach(entity => 
                    {
                        uow.Insert<TEntity>(entity);                     
                    });
                });

                return entities.Count();
            }            
        }

        public virtual int UpdateBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    entities.ToList().ForEach(entity => 
                    {                    
                        uow.Update<TEntity>(entity);                     
                    });                 
                });

                return entities.Count();
            }
        }

        public virtual int DeleteBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>();
            
            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    entities.ToList().ForEach(entity =>
                    {
                        uow.Delete<TEntity>(entity);
                    });                                            
                });

                return entities.Count();
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

    }
}
