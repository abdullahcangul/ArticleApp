using ArticleApp.Business.Abstract;
using ArticleApp.Business.Concrete;
using ArticleApp.Business.Tools.LogTool;
using ArticleApp.Business.ValidationRules.FluentValidation;
using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories;
using ArticleApp.DTO.DTOs.Article;
using ArticleApp.DTO.DTOs.Category;
using ArticleApp.DTO.DTOs.CategoryArticle;
using ArticleApp.Entity.Concrete;
using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ArticleApp.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            
            

            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IArticleCategoryDal, EfArticleCategoryDal>();
            services.AddScoped<ICustomLogger, NLogAdapter>();
            services.AddScoped<IMapper, Mapper>();


            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryArticleDto>, CategoryArticleValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<ArticleAddDto>, ArticleAddValidator>();
            services.AddTransient<IValidator<ArticleUpdateDto>, ArticleUpdateValidator>();
        }
    }
}
