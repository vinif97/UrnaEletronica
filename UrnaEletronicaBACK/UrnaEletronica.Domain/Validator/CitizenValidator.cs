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
    public class CitizenValidator : AbstractValidator<Citizen>
    {
        public CitizenValidator()
        {
            RuleFor(citizen => citizen.CPF).Must(cpf => IsCPFValid(cpf)).WithMessage("Invalid CPF");
            RuleFor(citizen => citizen.FirstName).NotEmpty().WithMessage("First name cannot be empty");
            RuleFor(citizen => citizen.LastName).NotEmpty().WithMessage("Last name cannot be empty");
        }

        protected override bool PreValidate(ValidationContext<Citizen> context, ValidationResult result)
        {
            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure("", "Citizen cannot be null"));
                return false;
            }

            return base.PreValidate(context, result);
        }

        private bool IsCPFValid(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                return false;

            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digit;
            int sum;
            int remainder;

            tempCpf = cpf.Substring(0, 9);
            sum = 0;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];

            remainder = sum % 11;
            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            digit = remainder.ToString();

            tempCpf = tempCpf + digit;

            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];

            remainder = sum % 11;
            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            digit = digit + remainder.ToString();

            return cpf.EndsWith(digit);
        }

    }
}
