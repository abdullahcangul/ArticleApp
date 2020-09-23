using ArticleApp.DTO.DTOs.Category;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.ValidationRules.FluentValidation
{
   public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Kategori adı alanı boş geçilemez!");
        }
    }
}
