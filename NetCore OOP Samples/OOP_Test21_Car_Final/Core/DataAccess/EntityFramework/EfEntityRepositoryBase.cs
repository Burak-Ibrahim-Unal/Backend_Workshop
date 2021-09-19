using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext tc = new TContext())
            {
                var added = tc.Entry(entity);
                added.State = EntityState.Deleted;
                tc.SaveChanges();
            }

        }
        public void Delete(TEntity entity)
        {
            using (TContext tc = new TContext())
            {
                var deleted = tc.Entry(entity);
                deleted.State = EntityState.Deleted;
                tc.SaveChanges();
            }

        }

        public void Update(TEntity entity)
        {
            using (TContext tc = new TContext())
            {
                var updated = tc.Entry(entity);
                updated.State = EntityState.Modified;
                tc.SaveChanges();
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext tc = new TContext())
            {
                return tc.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext tc = new TContext())
            {
                return filter == null ? tc.Set<TEntity>().ToList() : tc.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
