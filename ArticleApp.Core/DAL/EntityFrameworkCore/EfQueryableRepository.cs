using ArticleApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.Core.DAL.EntityFrameworkCore
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private DbSet<T> _entities;

        public EfQueryableRepository(DbContext dbContext)
        {
            _context = dbContext;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
    }
}
