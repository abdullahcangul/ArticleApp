using ArticleApp.Business.Abstract;
using ArticleApp.Business.Concrete;
using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories;
using ArticleApp.Entity.Concrete;
using AutoMapper;
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
            services.AddScoped<IMapper, Mapper>();


        }
    }
}
