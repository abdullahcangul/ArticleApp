using ArticleApp.Business.Abstract;
using ArticleApp.Core.Utilty;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DAL.Abstract;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal):base(categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAllWithCategoryArticles()
        {
          return _categoryDal.GetAllWithCategoryArticles();
        }

        public List<Category> GetAllSortedById()
        {
            return _categoryDal.GetList(I => I.Id);
        }

        public IResult DeleteCorrect(int id)
        {
           var category= _categoryDal.GetById(id);
            if (category.ArticleCategories==null ||category.ArticleCategories.Count== 0)
            {
                _categoryDal.Delete(category);
                return new SuccessResult(Messages.SUCCESS_DELETE);
            }
            return new ErrorResult(Messages.ERROR_DELETE_HAVE_ARTICLE);
        }
    }
}
