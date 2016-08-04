﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Linq.Expressions;
using Microsoft.Practices.Unity;
using Z.EntityFramework.Extensions;
using log4net;

namespace Xy.Pis.Core
{
    public class EFUnitOfWork<TDbContext> : IUnitOfWork 
        where TDbContext : DbContext
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private IDictionary<Type, object> repositories = new Dictionary<Type, object>();
        //private DbContext efContext;

        private bool disposed = false;
        private bool bulkOperation = false;

        [Dependency]
        public DbContext EFContext
        {
            get;
            set;
        }

        public bool IsConnectionOpen 
        {
            get { return EFContext != null; } 
        }

        public void Insert<TEntity>(TEntity entity) 
            where TEntity : class, new()
        {
            InitializeEFContext();

            GetRepository<TEntity>().Insert(entity);
        }

        public void Update<TEntity>(TEntity entity) 
            where TEntity : class, new()
        {
            InitializeEFContext();

            GetRepository<TEntity>().Update(entity);
        }

        public TEntity GetById<TEntity>(params object[] ids) 
            where TEntity : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntity>().GetById(ids);
        }

        public IQueryable<TEntity> Get<TEntity>() 
            where TEntity : class, new()
        {
            InitializeEFContext();            
            return GetRepository<TEntity>().Get();
        }

        public IQueryable<TEntity> Get<TEntity>
            ( Expression<Func<TEntity, bool>> filter = null
            , Func<IQueryable<TEntity>
            , IOrderedQueryable<TEntity>> orderBy = null
            ) where TEntity : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntity>().Get(filter, orderBy);
        }

        public IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>
            ( Func<TEntityOuter, object> outerKeySelector
            , Func<TEntityInner, object> innerKeySelector
            , Func<TEntityOuter, TEntityInner, TResult> resultSelector
            ) where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntityOuter>().Get().Join
                ( GetRepository<TEntityInner>().Get()
                , outerKeySelector
                , innerKeySelector
                , resultSelector
                ).AsQueryable()
                ;
        }

        public IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>
            ( Func<TEntityOuter, object> outerKeySelector
            , Func<TEntityInner, object> innerKeySelector
            , Func<TEntityOuter, TEntityInner, TResult> resultSelector
            , IEqualityComparer<object> comparer
            ) where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntityOuter>().Get().Join
                ( GetRepository<TEntityInner>().Get()
                , outerKeySelector
                , innerKeySelector
                , resultSelector
                , comparer
                ).AsQueryable()
                ;
        }

        public IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>
            ( Func<TEntityOuter, object> outerKeySelector
            , Func<TEntityInner, object> innerKeySelector
            , Func<TEntityOuter, TEntityInner, TResult> resultSelector
            ) where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntityOuter>().Get().GroupJoin
                ( GetRepository<TEntityInner>().Get()
                , outerKeySelector
                , innerKeySelector
                , (p, q) => resultSelector(p, q.FirstOrDefault())
                ).AsQueryable()
                ;
        }

        public IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>
            ( Func<TEntityOuter, object> outerKeySelector
            , Func<TEntityInner, object> innerKeySelector
            , Func<TEntityOuter, TEntityInner, TResult> resultSelector
            , IEqualityComparer<object> comparer
            ) where TEntityOuter : class, new()
            where TEntityInner : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntityOuter>().Get().GroupJoin
                ( GetRepository<TEntityInner>().Get()
                , outerKeySelector
                , innerKeySelector
                , (p, q) => resultSelector(p, q.FirstOrDefault()), comparer
                ).AsQueryable()
                ;
        }

        public void DeleteById<TEntity>(params object[] ids) 
            where TEntity : class, new()
        {
            InitializeEFContext();

            GetRepository<TEntity>().DeleteById(ids);
        }

        public void Delete<TEntity>(TEntity entity) 
            where TEntity : class, new()
        {
            InitializeEFContext();

            GetRepository<TEntity>().Delete(entity);
        }       
        
        public void Query(Action query)
        {
            InitializeEFContext();

            query.Invoke();

            SaveChanges(true);
        }

        public void SaveChanges(bool withDisposing = false)
        {
            if (bulkOperation)
                EFContext.BulkSaveChanges();
            else
                EFContext.SaveChanges();
            
            bulkOperation = false;

            if (withDisposing)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {                    
                    if (EFContext != null)
                    {
                        EFContext.Dispose();
                        EFContext = null;
                    }

                    repositories.Clear();
                }
            }

            this.disposed = true;
        }

        private void InitializeEFContext()
        {
            //if (efContext == null)
            //{
            //    efContext = typeof(TDbContext).GetConstructor(new Type[] { }).Invoke(new object[] { }) as DbContext;
            //}
        }

        private IRepository<TEntity> GetRepository<TEntity>() 
            where TEntity : class, new()
        {
            if (!repositories.ContainsKey(typeof(TEntity)))
            {
                repositories.Add(new KeyValuePair<Type, object>(typeof(TEntity), new EFRepository<TEntity>(EFContext)));
            }

            return (IRepository<TEntity>)repositories[typeof(TEntity)];
        }

        public int Update<TEntity>
            ( Expression<Func<TEntity, bool>> filterExpression
            , Expression<Func<TEntity, TEntity>> updateExpression
            ) where TEntity : class, new()
        {
            InitializeEFContext();
            return GetRepository<TEntity>().Update(filterExpression, updateExpression);
        }

        public int Delete<TEntity>(Expression<Func<TEntity, bool>> queryExpression)
            where TEntity : class, new()
        {
            InitializeEFContext();
            return GetRepository<TEntity>().Delete(queryExpression);
        }

        public void AddBatch<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : class, new()
        {
            InitializeEFContext();
            GetRepository<TEntity>().AddBatch(entities);
        }

        public void UpdateBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            InitializeEFContext();
            GetRepository<TEntity>().UpdateBatch(entities);
        }

        public void DeleteBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            InitializeEFContext();
            GetRepository<TEntity>().DeleteBatch(entities);
        }

        public void BulkInsert<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : class, new()
        {
            bulkOperation = true;
            InitializeEFContext();
            GetRepository<TEntity>().BulkInsert(entities);
        }

        public void BulkDelete<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : class, new()
        {
            bulkOperation = true;
            InitializeEFContext();
            GetRepository<TEntity>().BulkDelete(entities);
        }

        public void BulkUpdate<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new()
        {
            bulkOperation = true;
            InitializeEFContext();
            GetRepository<TEntity>().BulkUpdate(entities);
        }

        public virtual int DeleteAll<TEntity>()
            where TEntity : class, new()
        {
            InitializeEFContext();

            return GetRepository<TEntity>().DeleteAll();
        }
    }
}