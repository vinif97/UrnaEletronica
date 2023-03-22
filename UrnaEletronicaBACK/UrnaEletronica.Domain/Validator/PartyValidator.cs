using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Validator
{
    public class PartyValidator : AbstractValidator<Party>
    {
        public PartyValidator()
        {
            RuleFor(party => party.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(party => party.Acronym).NotEmpty().WithMessage("Acronym cannot be empty");
            RuleFor(party => party.Acronym).MaximumLength(6).WithMessage("Acronym cannot have more than 6 digits");
            RuleFor(party => party.Description).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
