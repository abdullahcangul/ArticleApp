using ArticleApp.DTO.DTOs.Article;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.ValidationRules.FluentValidation
{
    class ArticleUpdateValidator : AbstractValidator<ArticleUpdateDto>
    {
        public ArticleUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(I => I.Content).NotEmpty().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
