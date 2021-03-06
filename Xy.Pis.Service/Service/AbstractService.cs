﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Transactions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using Microsoft.Practices.Unity;
using Xy.Pis.Contract.Service;
using Xy.Pis.Core;
using Xy.Pis.Utils.Unity;

namespace Xy.Pis.Service
{
    public abstract class AbstractService<TEntity, TDTO> : Profile, IService<TDTO> 
        where TEntity : EntityBase, new()
        where TDTO : DTOBase, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);        

        [Dependency]
        public virtual ICommandWrapper CommandWrapper
        {
            get { return IoC.Resolve<ICommandWrapper>(); }
        }        

        public virtual TDTO Add(TDTO dto)
        {
            dto.Validation();

            var entity = dto.MapTo<TEntity>();

            using (var command = this.CommandWrapper)
            {                
                command.Execute(uow =>
                {
                    uow.Add<TEntity>(entity);
                });
                
                return entity.MapTo<TDTO>();
            }
        }

        public virtual Tuple<int, int> AddOrUpdate(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var addedEntities = dtos.Where(x => x.ID == 0).MapTo<TEntity>().ToList();
            var updatedEntities = dtos.Where(x => x.ID != 0).MapTo<TEntity>().ToList();
            int addedRows = 0;
            int updatedRows = 0;

            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {
                    addedEntities.ForEach(entity =>
                    {
                        uow.Add(entity);
                        addedRows++;
                    });

                    updatedEntities.ForEach(entity =>
                    {
                        uow.Update(entity);
                        updatedRows++;
                    });
                });

                return new Tuple<int, int>(addedRows, updatedRows);
            }
        }

        public virtual void Delete(TDTO dto)
        {
            dto.Validation();

            int pid = dto.ID;
            
            this.Delete(x => x.ID == pid);
        }

        public virtual void DeleteById(object key)
        {
            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.DeleteById<TEntity>(key);
                });
            }
        }

        public virtual int DeleteAll()
        {
            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.DeleteAll<TEntity>();
                });
            }
        }      

        public virtual void Update(TDTO dto)
        {
            dto.Validation();
            
            var entity = dto.MapTo<TEntity>();

            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Update<TEntity>(entity);
                });
            }
        }

        public virtual TDTO GetById(object key) 
        {
            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.GetById<TEntity>(key).MapTo<TDTO>();                    
                });
            }
        }        
        
        public virtual IEnumerable<TDTO> GetAll() 
        {
            using (var command = this.CommandWrapper)
            {                
                return command.Execute(uow =>
                {
                    return uow.Get<TEntity>().MapTo<TDTO>();
                });
            }
        }        

        public virtual int AddBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>().ToList();

            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow => 
                {
                    int effectedRows = 0;

                    entities.ForEach(entity => 
                    {
                        uow.Add<TEntity>(entity);
                        effectedRows++;
                    });

                    return effectedRows;
                });
            }            
        }

        public virtual int DeleteBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>().ToList();

            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    int effectedRows = 0;

                    entities.ForEach(entity =>
                    {
                        uow.Delete<TEntity>(entity);
                        effectedRows++;
                    });

                    return effectedRows;
                });
            }
        }

        public virtual int UpdateBatch(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();

            var entities = dtos.MapTo<TEntity>().ToList();

            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    int effectedRows = 0;

                    entities.ForEach(entity => 
                    {                    
                        uow.Update<TEntity>(entity);
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

            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {                    
                    uow.BulkInsert<TEntity>(entities);
                });
            }
        }

        public virtual void BulkDelete(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.BulkDelete<TEntity>(entities);
                });
            }
        }

        public virtual void BulkUpdate(IEnumerable<TDTO> dtos)
        {
            dtos.Validation();
            var entities = dtos.MapTo<TEntity>();

            using (var command = this.CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.BulkUpdate<TEntity>(entities);
                });
            }
        }        

        public virtual IEnumerable<TDTO> Get(Expression<Func<TDTO, bool>> predicate)
        {
            var expression = Mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            
            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Get<TEntity>(expression).MapTo<TDTO>();
                });
            }
        }

        public virtual int Delete(Expression<Func<TDTO, bool>> expression)
        {
            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(expression);

            using (var command = this.CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Delete<TEntity>(predicate);
                });
            }
        }

        public virtual int Update(Expression<Func<TDTO, bool>> filterExpression, Expression<Func<TDTO, TDTO>> updateExpression)
        {
            throw new NotImplementedException();

            // dto.Validation();

            // TEntity entity1 = dto.MapTo<TEntity>();
            ////var filterExpressionForEntity = Mapper.Map<Expression<Func<TEntity, bool>>>(filterExpression);
            ////var updateExpressionForEntity = Mapper.Map<Expression<Func<TEntity, TEntity>>>(updateExpression);            

            ////using (var command = this.CommandWrapper)
            ////{
            ////    return command.Execute(uow =>
            ////    {
            ////        return uow.Update<TEntity>(filterExpressionForEntity, updateExpressionForEntity);
            ////    });
            ////}
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TEntity, TDTO>();
            Mapper.CreateMap<TDTO, TEntity>();
        }
    }
}
