using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Validator;

namespace UrnaEletronica.Application.ValidationHandler
{
    public static class SignUpUserValidationHandler
    {
        public static IResult ValidateNewUser(User user)
        {
            OperationResult operationResult = new();
            UserValidator userValidator = new();
            CitizenValidator citizenValidator = new();
            AddressValidator addressValidator = new();

            DomainValidationHandler<User>.Validate(user, userValidator, operationResult);

#pragma warning disable CS8604 // Has null validation.
            DomainValidationHandler<Citizen>.Validate(user.Citizen, citizenValidator, operationResult);
            DomainValidationHandler<Address>.Validate(user.Address, addressValidator, operationResult);
#pragma warning restore CS8604 // Has null validation.

            if (operationResult.Errors.Count > 0)
                operationResult.IsSuccess = false;

            return operationResult;
        }
    }
}
