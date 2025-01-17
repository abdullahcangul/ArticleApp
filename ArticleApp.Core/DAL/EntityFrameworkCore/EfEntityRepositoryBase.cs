﻿
using ArticleApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArticleApp.Core.DAL.EntityFrameworkCore
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public  TEntity GetById(int id)
        {
            using var context = new TContext();
            return  context.Find<TEntity>(id);
        }

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new TContext();
            return  context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToList();
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new TContext();
            return context.Set<TEntity>().OrderByDescending(keySelector).ToList();
        }

  
    }
}
