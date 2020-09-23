using ArticleApp.Core.DAL;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Abstract
{
    public interface IArticleDal: IEntityRepository<Article>
    {
        public List<Category> GetCategoriesByArticleId(int ArticleId);
        public List<Comment> GetCommentsByArticleId(int ArticleId);
        public List<Article> GetAllByCategory(int categoryId);
    }
}
