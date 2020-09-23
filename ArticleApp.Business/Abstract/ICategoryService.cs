using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.Contexts;
using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public List<Category> GetAllWithCategoryArticles();
        public List<Category> GetAllSortedById();
        public IResult DeleteCorrect(int id);
    }
}
