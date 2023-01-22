using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Validator
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.StreetAddress).NotEmpty().WithMessage("Street address cannot be empty");
            RuleFor(address => address.Number).GreaterThan((short)0).WithMessage("Street number cannot be empty");
        }

        protected override bool PreValidate(ValidationContext<Address> context, ValidationResult result)
        {
            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure("", "Address cannot be null"));
                return false;
            }

            return base.PreValidate(context, result);
        }
    }
}
