using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Username cannot be empty");
            RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage("Invalid email");
            RuleFor(user => user.Password.PasswordString).NotEmpty().WithMessage("Password cannot be empty")
                .Equal(user => user.Password.ConfirmPassword).WithMessage("Passwords aren't equal");
        }
    }
}
