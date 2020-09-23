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
    public class EfArticleDal : EfEntityRepositoryBase<Article, ArticleAppContext>, IArticleDal
    {
        public List<Category> GetCategoriesByArticleId(int articleId)
        {
            using ArticleAppContext db = new ArticleAppContext();
            return db.ArticleCategory.Where(x => x.ArticleId == articleId).Select(x => x.Category).ToList();
        }

        public List<Comment> GetCommentsByArticleId(int ArticleId)
        {
            using ArticleAppContext db = new ArticleAppContext();
            return db.Comments.Where(x => x.ArticleID == ArticleId).ToList();
        }

        public List<Article> GetAllByCategory(int categoryId)
        {
            using ArticleAppContext db = new ArticleAppContext();
            return  db.Articles.Join(db.ArticleCategory, a => a.Id, ac => ac.ArticleId, (article, articleCategory) => new
            {
                article,
                articleCategory
            }).Where(I => I.articleCategory.CategoryId == categoryId).Select(I => new Article
            {
                Id=I.article.Id,
                Uid=I.article.Uid,
                State=I.article.State,
                Title =I.article.Title,
                Comments=I.article.Comments,
                Content=I.article.Content,
                Description=I.article.Description,
            }).ToList();
        }
    }
}
