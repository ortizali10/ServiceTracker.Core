using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ServiceTracker.Core.Repository
{
    public interface IRepository
    {
        TEntity Get<TEntity>(int id) where TEntity : class;
        IEnumerable<TEntity> Getall<TEntity>() where TEntity : class;
        IEnumerable<TEntity> Getall<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        void Add<TEntity>(TEntity entity) where TEntity : class;
        void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        void Remove<TEntity>(TEntity entity) where TEntity : class;
        void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        void Update<TEntity>(TEntity entity) where TEntity : class;

        void Save();
    }
}