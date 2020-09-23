using ArticleApp.Core.DAL;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
        public List<Category> GetAllWithCategoryArticles();
    }
}
