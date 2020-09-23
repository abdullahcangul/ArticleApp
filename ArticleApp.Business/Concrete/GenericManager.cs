using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.Core.Entities.Abstract;
using ArticleApp.Core.Utilty.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _genericDal;
        public GenericManager(IEntityRepository<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public IDataResult<TEntity> Add(TEntity entity)
        {
           return new SuccessDataResult<TEntity>( _genericDal.Add(entity));
        }

        public void Delete(TEntity entity)
        {
            _genericDal.Delete(entity);
        }

        public IDataResult<TEntity> Update(TEntity entity)
        {
            return new SuccessDataResult<TEntity>(_genericDal.Update(entity));
        }

        public IDataResult<TEntity> GetById(int id)
        {
            return new SuccessDataResult<TEntity>(_genericDal.GetById(id));
        }

        public IDataResult<List<TEntity>> GetAll()
        {
            return new SuccessDataResult<List<TEntity>>(_genericDal.GetList());
        }

       
    }
}
