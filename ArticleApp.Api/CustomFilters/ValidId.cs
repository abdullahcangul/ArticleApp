using ArticleApp.Business.Abstract;
using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Api.CustomFilters
{
    public class ValidId<TEntity> : IActionFilter where TEntity : class, IEntity, new()
    {
        private readonly IArticleService _genericService;
        public ValidId(IArticleService genericService)
        {
            _genericService = genericService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.Where(I => I.Key == "id").FirstOrDefault();

            var id = int.Parse(dictionary.Value.ToString());

            var entity = _genericService.GetById (id).Data;
            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"{id} degerine sahip nesne bulunamadı");
            }
        }
    }
}
