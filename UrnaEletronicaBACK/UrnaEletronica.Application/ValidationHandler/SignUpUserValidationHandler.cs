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

            if (user is not null)
            {
                DomainValidationHandler<Citizen>.Validate(user.Citizen, citizenValidator, operationResult);
                DomainValidationHandler<Address>.Validate(user.Address, addressValidator, operationResult);
            }

            if (operationResult.Errors.Count > 0)
                operationResult.IsSuccess = false;

            return operationResult;
        }
    }
}
