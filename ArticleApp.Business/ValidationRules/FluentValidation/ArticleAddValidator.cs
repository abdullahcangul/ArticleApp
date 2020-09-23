using ArticleApp.DTO.DTOs.Article;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.ValidationRules.FluentValidation
{
    public class ArticleAddValidator : AbstractValidator<ArticleAddDto>
    {
        public ArticleAddValidator()
        {
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(I => I.Content).NotEmpty().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
