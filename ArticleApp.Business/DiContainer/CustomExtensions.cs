using ArticleApp.Business.Abstract;
using ArticleApp.Business.Concrete;
using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.Core.DAL.EntityFrameworkCore;
using ArticleApp.Core.Entities.Abstract;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
           

            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IMapper, Mapper>();


        }
    }
}
