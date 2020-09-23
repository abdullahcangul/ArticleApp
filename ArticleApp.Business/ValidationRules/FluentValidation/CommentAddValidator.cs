using ArticleApp.DTO.DTOs.Comment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("UserName alanı boş bırakılamaz");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz");

            RuleFor(I => I.Content).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

        }
    }
}
