﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Z.EntityFramework.Extensions;
using System.Data.Entity;

namespace Xy.Pis.Core
{    
    /// <summary>
    /// 工作单元接口，提供一系列介于工作单元的实体操作方法。
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Entity Framework DBContext
        /// </summary>
        DbContext EFContext { get; set; }
    
        /// <summary>
        /// 指示数据库连接是否打开
        /// </summary>
        bool IsConnectionOpen { get; }

        /// <summary>
        /// 插入单个实体到数据库
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity">待插入实体对象</param>
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
