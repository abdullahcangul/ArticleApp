using ArticleApp.Business.Abstract;
using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.Core.Utilty;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DAL.Abstract;
using ArticleApp.DTO.DTOs.CategoryArticle;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class ArticleManager : GenericManager<Article>, IArticleService
    {
        private readonly IArticleDal _articleDal;
        private readonly IEntityRepository<ArticleCategory> _categoryArticleService;

        public ArticleManager(IArticleDal articleDal, IEntityRepository<ArticleCategory> categoryArticleService) : base(articleDal)
        {
            _articleDal = articleDal;
            _categoryArticleService = categoryArticleService;
        }

        public void  AddToCategory(CategoryArticleDto categoryArticleDto)
        {
            var control =  _categoryArticleService.Get(I => I.CategoryId == categoryArticleDto.CategoryID && I.ArticleId == categoryArticleDto.ArticleID);
            if (control == null)
            {
                 _categoryArticleService.Add(new ArticleCategory
                {
                    ArticleId = categoryArticleDto.ArticleID,
                    CategoryId = categoryArticleDto.CategoryID
                });
            }
        }

        public void RemoveFromCategory(CategoryArticleDto categoryArticleDto)
        {
            var deletedCategoryArticle = _categoryArticleService.Get(I => I.CategoryId == categoryArticleDto.CategoryID && I.ArticleId == categoryArticleDto.ArticleID);
            if (deletedCategoryArticle != null)
            {
                _categoryArticleService.Delete(deletedCategoryArticle);
            }
        }

        public IDataResult<List<Category>> GetCategoriesByArticleId(int articleId)
        {
            return new SuccessDataResult<List<Category>>(_articleDal.GetCategoriesByArticleId(articleId));
        }

        public IDataResult<List<Comment>> GetCommentsByArticleId(int articleId)
        {
            return new SuccessDataResult<List<Comment>>(_articleDal.GetCommentsByArticleId(articleId));
        }

        public IDataResult<List<Article>> GetAllSortedByLastEditDate()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList(I => I.LastEditDate));
        }

        public IDataResult<List<Article>> GetAllByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAllByCategory(categoryId));
        }
        public IDataResult<List<Article>> Search(string searchString)
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList(I => I.Title.Contains(searchString) || I.Content.Contains(searchString) || I.Description.Contains(searchString), I => I.LastEditDate));
        }

        
    }
}
