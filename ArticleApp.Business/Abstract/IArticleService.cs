using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DTO.DTOs.CategoryArticle;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface IArticleService:IGenericService<Article>
    {
       
        public IDataResult<List<Category>> GetCategoriesByArticleId(int articleId);
        public IDataResult<List<Comment>> GetCommentsByArticleId(int articleId);
        public IDataResult<List<Article>> GetAllSortedByLastEditDate();
        public IDataResult<List<Article>> GetAllByCategory(int categoryId);
        public IDataResult<List<Article>> Search(string searchString);
        public void AddToCategory(CategoryArticleDto categoryArticleDto);
        public void RemoveFromCategory(CategoryArticleDto categoryArticleDto);
    }
}
