using ECommerce.Domain.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.DataAcces.EntityFrameWorkAcces
{
    public abstract class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using var context = new TContext();
            var newEntity = context.Entry(entity);
            newEntity.State = EntityState.Added;
            //context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            //context.Remove(deletedEntity);
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter)!;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null ? [.. context.Set<TEntity>().ToList()] :
                [.. context.Set<TEntity>().Where(filter)];

        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var upDatedEntity = context.Entry(entity);
            upDatedEntity.State = EntityState.Modified;
            //context.Update(upDatedEntity);
            context.SaveChanges();
        }
    }
}















