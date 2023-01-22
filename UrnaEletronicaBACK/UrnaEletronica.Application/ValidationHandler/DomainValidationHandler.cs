using FluentValidation;
using FluentValidation.Results;
using UrnaEletronica.Application.Interfaces.ValidationHandler;

namespace UrnaEletronica.Application.ValidationHandler
{
    public static class DomainValidationHandler<T> where T : class
    {
        public static void Validate(T domainClassToBeValidated, AbstractValidator<T> validator, IResult result)
        {
            ValidationResult validationResult = validator.Validate(domainClassToBeValidated);

            if (!validationResult.IsValid)
            {
                result.IsSuccess = false;

                foreach (var error in validationResult.Errors)
                {
                    result.Errors.Add(error.ToString());
                }
            }

            result.IsSuccess = true;
        }
    }
}
