using ArticleApp.Core.DAL.EntityFrameworkCore;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.Contexts;
using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category, ArticleAppContext>, ICategoryDal
    {
        public List<Category> GetAllWithCategoryArticles()
        {
            using var context = new ArticleAppContext();
            return context.Categories.OrderByDescending(I => I.Id).Include(I => I.ArticleCategories).ToList();
        }
    }
}
