using FluentValidation.Results;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Validator;
using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Domain.Test
{
    public class CitizenValidatorTest
    {
        [Fact]
        public void WhenCitizenNull_ReturnError()
        {
            string expectedResult = "Citizen cannot be null";

            Citizen? citizen = null;
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen!);

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }

        [Fact]
        public void WhenPropretiesValids_DontReturnError()
        {
            Citizen? citizen = new(new CitizenIdentity("799.755.880-26", "Vinicius", "Oliveira"));
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.True(validationResult.IsValid);
        }

        [Fact]
        public void WhenCPFisInvalid_ReturnError()
        {
            string expectedResult = "Invalid CPF";

            Citizen? citizen = new(new CitizenIdentity("555.777.880-36", "Vinicius", "Oliveira"));
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }

        [Fact]
        public void WhenCPFisNullOrEmpty_ReturnError()
        {
            string expectedResult = "Invalid CPF";

            Citizen? citizen = new(new CitizenIdentity("", "Vinicius", "Oliveira"));
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }
    }
}