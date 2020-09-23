using ArticleApp.Core.Entities.Abstract;
using ArticleApp.Core.Utilty.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Core.Business.Abstract
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        IDataResult<T> Add(T entity);
        void Delete(T entity);
        IDataResult<T> Update(T entity);
        IDataResult<T>  GetById(int id);
        IDataResult<List<T>> GetAll();
    }
}
