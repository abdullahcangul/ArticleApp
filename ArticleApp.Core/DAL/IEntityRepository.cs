using ArticleApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArticleApp.Core.DAL
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        List<T> GetList<TKey>(Expression<Func<T, TKey>> keySelector);
        List<T> GetList<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> keySelector);
        T Get(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        T GetById(int id);
        void Delete(T entity);
    }
}
