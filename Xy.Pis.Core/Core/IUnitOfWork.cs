using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Z.EntityFramework.Extensions;

namespace Xy.Pis.Core
{
    public interface IUnitOfWork : IDisposable
    {        
        DbContext EFContext { get; set; }
    
        bool IsConnectionOpen { get; }

        void Add<TEntity>(TEntity entity) where TEntity : class, new();

        void Update<TEntity>(TEntity entity) where TEntity : class, new();
       
        TEntity GetById<TEntity>(params object[] ids) where TEntity : class, new();
    
        IQueryable<TEntity> Get<TEntity>() where TEntity : class, new();
        
        IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) where TEntity : class, new();
               
        void DeleteById<TEntity>(params object[] ids) where TEntity : class, new();
        
        void Delete<TEntity>(TEntity entity) where TEntity : class, new();
              
        IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector) 
            where TEntityInner : class, new() 
            where TEntityOuter : class, new();
      
        IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer) 
            where TEntityInner : class, new()
            where TEntityOuter : class, new();
    
        IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector) 
            where TEntityInner : class, new()
            where TEntityOuter : class, new();
        
        IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer) 
            where TEntityInner : class, new()
            where TEntityOuter : class, new();        
     
        void Query(Action query);

        void SaveChanges(bool withDisposing = false);

        int Update<TEntity>(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression) 
            where TEntity : class, new();

        int Delete<TEntity>(Expression<Func<TEntity, bool>> queryExpression) 
            where TEntity : class, new();

        int DeleteAll<TEntity>() where TEntity : class, new();

        void AddBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new();

        void UpdateBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new();

        void DeleteBatch<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class, new();

        void BulkInsert<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, new();
      
        void BulkDelete<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, new();

        void BulkUpdate<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, new();        
    }    
}
