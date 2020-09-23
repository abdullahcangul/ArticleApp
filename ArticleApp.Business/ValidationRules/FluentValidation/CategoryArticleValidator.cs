using ArticleApp.DTO.DTOs.CategoryArticle;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.ValidationRules.FluentValidation
{
    public class CategoryArticleValidator : AbstractValidator<CategoryArticleDto>
    {
        public CategoryArticleValidator()
        {
            RuleFor(I => I.CategoryID).InclusiveBetween(0, int.MaxValue).WithMessage("CategoryId boş geçilemez");
            RuleFor(I => I.ArticleID).InclusiveBetween(0, int.MaxValue).WithMessage("Article Id boş geçilemez");
        }
    }
}
