using FluentValidation;
using MediumAppMP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Business.ValidationRules.FluentValidation
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(p=>p.ArticleContentId).NotEmpty();
            RuleFor(p => p.Content).NotEmpty();
            RuleFor(p => p.Id).NotEmpty();
        }        
    }
}
