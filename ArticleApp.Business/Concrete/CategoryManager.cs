using ArticleApp.Business.Abstract;
using ArticleApp.DAL.Abstract;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
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
          return   _categoryDal.GetAllWithCategoryArticles();
        }
    }
}
