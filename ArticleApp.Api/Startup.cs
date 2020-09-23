using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Api.CustomFilters;
using ArticleApp.Business.DiContainer;
using ArticleApp.DAL.Concrete.Contexts;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ArticleApp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            opt.SwaggerDoc("doc", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title="Article App",
                Description="Asp.Net Core Api Article App ",
                Contact=new Microsoft.OpenApi.Models.OpenApiContact
                {
                    Email="abdullahcangul@gmail.com",
                    Name="Abdullah CANGUL",
                    Url=new Uri("https://www.linkedin.com/in/abdullah-cangul-b842b111b/")
                }
            })
                ); ;
            services.AddAutoMapper(typeof(Startup));
            services.AddContainerWithDependencies();
            services.AddScoped(typeof(ValidId<>));
            services.AddDbContext<ArticleAppContext>();
            services.AddMemoryCache();
            services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            }).AddFluentValidation(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            app.UseExceptionHandler("/api/Error");
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(opt=>
            {
                opt.SwaggerEndpoint("/swagger/doc/swagger.json", "Article App");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
