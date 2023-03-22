using AutoMapper;
using Moq;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Mappers;
using UrnaEletronica.Application.Services;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Test.Services
{
    public class PartyServiceTest
    {
        private readonly IMapper mapper;
        public PartyServiceTest()
        {
            var mapperConfig = new MapperConfiguration(config => config.AddProfile(new PartyProfile()));

            mapper = mapperConfig.CreateMapper();
        }
        [Fact]
        public void CreateParty_Returns_Fail_When_ExceptionIsThrown()
        {
            var partyRepository = new Mock<IPartyRepository>();
            partyRepository.Setup(a => a.CreateParty(It.IsAny<Party>())).Throws(new Exception());

            var service = new PartyService(mapper, partyRepository.Object);
            var result = service.CreateParty(new PartyDto()).Result;

            Assert.NotEmpty(result.Errors);
            Assert.False(result.IsSuccess);
        }
    }
}