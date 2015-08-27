using System;
using System.Linq;
using System.Linq.Expressions;
using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories.Contracts
{
    public interface IRepository<TId, TEntity> where TEntity : BaseEntity<TId>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity,bool>> criteria);
        TEntity GetById(TId id);
        
    }
}
