﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Linq.Expressions;
using EntityFramework.Extensions;
using Z.EntityFramework.Extensions;
using log4net;

namespace Xy.Pis.Core
{   
    internal class EFRepository<TEntity> : IRepository<TEntity> 
        where TEntity : class, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private DbSet<TEntity> EFSet { get; set; }

        private DbContext EFContext { get; set; }

        public EFRepository(DbContext efContext)
        {
            efContext.Database.CommandTimeout = 600000;

            //Log.DebugFormat("Database CommandTimeout: {0} ms", efContext.Database.CommandTimeout);
            
            EFSet = efContext.Set<TEntity>();
            EFContext = efContext;            
        }

        public void Insert(TEntity entity)
        {
            EFSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
             
            if (EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                EFSet.Attach(entity);
            }
            else
            {
                EFContext.Entry<TEntity>(entity).CurrentValues.SetValues(entity);
            }

            EFContext.Entry<TEntity>(entity).State = EntityState.Modified;            
        }

        public void Delete(TEntity entity)
        {
            if (EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                EFSet.Attach(entity);
            }

            EFSet.Remove(entity);
        }

        public virtual TEntity GetById(params object[] ids)
        {
            return EFSet.Find(ids);
        }

        public virtual IQueryable<TEntity> Get()
        {
            return EFSet;
        }

        public virtual void DeleteById(params object[] ids)
        {
            Delete(GetById(ids));
        }

        public virtual int DeleteAll()
        {
            return EFSet.Delete();
        }

        #region Lambda Expression Operations
        public virtual IQueryable<TEntity> Get
           ( Expression<Func<TEntity, bool>> filter = null
           , Func<IQueryable<TEntity>
           , IOrderedQueryable<TEntity>> orderBy = null
           )
        {
            IQueryable<TEntity> query = EFSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public virtual List<TEntity> Get
            ( Expression<Func<TEntity, bool>> filter = null
            , Func<IQueryable<TEntity>
            , IOrderedQueryable<TEntity>> orderBy = null
            , string includeProperties = ""
            )
        {
            IQueryable<TEntity> query = EFSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual int Update
            ( Expression<Func<TEntity, bool>> filterExpression
            , Expression<Func<TEntity, TEntity>> updateExpression
            )
        {
            return EFSet.Where(filterExpression).Update(updateExpression);
        }

        public virtual int Delete(Expression<Func<TEntity, bool>> queryExpression)
        {
            return EFSet.Where(queryExpression).Delete();
        }
        #endregion

        #region Batch Operations
        public void AddBatch(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(entity =>
            {            
                this.Insert(entity);
            });
        }

        public void UpdateBatch(IEnumerable<TEntity> entities) 
        {
            entities.ToList().ForEach(entity =>
            {            
                this.Update(entity);
            });
        }

        public void DeleteBatch(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(entity => 
            {
                this.Delete(entity);
            });
        }
        #endregion        

        #region Bulk Operation
        public virtual void BulkInsert(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkInsert(entities);
        }

        public virtual void BulkDelete(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkDelete(entities);
        }

        public virtual void BulkUpdate(IEnumerable<TEntity> entities)
        {
            this.EFContext.BulkUpdate(entities);
        }
        #endregion
    }
}