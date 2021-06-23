using Domain.Entities;
using FluentValidation;
using System;

namespace Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(r => r.Id).NotNull().NotEqual(new Guid());
            RuleFor(r => r.UserName).NotNull().NotEmpty();
            RuleFor(r => r.Email).NotNull().NotEmpty();
        }
    }
}
