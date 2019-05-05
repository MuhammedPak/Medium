using FluentValidation;
using MediumAppMP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Business.ValidationRules.FluentValidation
{
    public  class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.BirthDate).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
