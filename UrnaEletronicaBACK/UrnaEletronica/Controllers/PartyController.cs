using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Infrastructure.Migrations;

namespace UrnaEletronica.WebApi.Controllers
{
    [Route("api/party")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        private readonly IPartyService _partyService;

        public PartyController(IPartyService partyService)
        {
            _partyService = partyService;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("create-party")]
        public async Task<IActionResult> CreateParty(PartyDto partyDto)
        {
            IResult result = await _partyService.CreateParty(partyDto);

            if (result.IsSuccess)
                return Ok();

            return BadRequest(result.Errors);
        }

        [Authorize(Roles = "admin,citizen")]
        [HttpGet("parties")]
        public async Task<IActionResult> GetAllParties()
        {
            var parties = await _partyService.GetAllParties();
            return Ok(parties);
        }
    }
}
