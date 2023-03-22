using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moq;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.WebApi.Controllers;

namespace UrnaEletronica.WebApi.Test.Controllers
{
    public class PartyControllerTest
    {
        [Fact]
        public void CreateParty_Has_AuthorizeAttribute()
        {
            var mockService = new Mock<IPartyService>();
            var controller = new PartyController(mockService.Object);

            var type = controller.GetType();
            var methodInfo = type.GetMethod("CreateParty", new Type[] { typeof(PartyDto) });
            var attributes = methodInfo!.GetCustomAttributes(typeof(AuthorizeAttribute), true);
            var authorizeAttributes = (AuthorizeAttribute)attributes[0];

            Assert.Equal("admin", authorizeAttributes.Roles);
        }

        [Fact]
        public void CreateParty_Returns_BadRequest_When_Operation_Fails()
        {
            IResult result = new OperationResult() { IsSuccess = false };

            var mockService = new Mock<IPartyService>();
            mockService.Setup(a => a.CreateParty(It.IsAny<PartyDto>())).ReturnsAsync(result);
            var controller = new PartyController(mockService.Object);

            BadRequestObjectResult actionResult = (BadRequestObjectResult)controller.CreateParty(new PartyDto()).Result;

            Assert.Equal(400, actionResult.StatusCode);
        }

        [Fact]
        public void CreateParty_Returns_BadRequest_When_Operation_Succeededs()
        {
            IResult result = new OperationResult() { IsSuccess = true };

            var mockService = new Mock<IPartyService>();
            mockService.Setup(a => a.CreateParty(It.IsAny<PartyDto>())).ReturnsAsync(result);
            var controller = new PartyController(mockService.Object);

            OkResult actionResult = (OkResult)controller.CreateParty(new PartyDto()).Result;

            Assert.Equal(200, actionResult.StatusCode);
        }
    }
}