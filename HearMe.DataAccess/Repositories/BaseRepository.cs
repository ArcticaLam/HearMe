using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HearMe.DataAccess.Entities;
using HearMe.DataAccess.Repositories.Contracts;

namespace HearMe.DataAccess.Repositories
{
    public class BaseRepository<TId, TEntity> : IRepository<TId, TEntity> where TEntity : BaseEntity<TId>
    {
        private readonly HearMeDataContext context;

        public BaseRepository(HearMeDataContext dataContext)
        {
            context = dataContext;
        }

        public void Add(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        public IQueryable<TEntity> GetAll() => context.Set<TEntity>().AsQueryable();

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> criteria) => context.Set<TEntity>().Where(criteria).AsQueryable();

        public TEntity GetById(TId id) => context.Set<TEntity>().Find(id);
    }
}
