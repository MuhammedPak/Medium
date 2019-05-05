using FluentValidation;
using MediumAppMP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Business.ValidationRules.FluentValidation
{
    public class TagValidator : AbstractValidator<Tag>
    {
        public TagValidator()
        {
            RuleFor(x => x.ArticleId).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();            
        }
    }
}
