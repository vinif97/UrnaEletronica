using FluentValidation.Results;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Validator;

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
#pragma warning disable CS8604 // Possible null reference argument.
            ValidationResult validationResult = validator.Validate(citizen);
#pragma warning restore CS8604 // Possible null reference argument.

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }

        [Fact]
        public void WhenPropretiesValids_DontReturnError()
        {
            Citizen? citizen = new();
            citizen.CPF = "799.755.880-26";
            citizen.FirstName = "Vinicius";
            citizen.LastName = "Oliveira";
            citizen.CleanCPF();
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.True(validationResult.IsValid);
        }

        [Fact]
        public void WhenCPFisInvalid_ReturnError()
        {
            string expectedResult = "Invalid CPF";

            Citizen? citizen = new();
            citizen.CPF = "555.666.000-15";
            citizen.CleanCPF();
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }

        [Fact]
        public void WhenCPFisNullOrEmpty_ReturnError()
        {
            string expectedResult = "Invalid CPF";

            Citizen? citizen = new();
            CitizenValidator validator = new();
            ValidationResult validationResult = validator.Validate(citizen);

            Assert.Equal(expectedResult, validationResult.Errors[0].ErrorMessage);
        }
    }
}