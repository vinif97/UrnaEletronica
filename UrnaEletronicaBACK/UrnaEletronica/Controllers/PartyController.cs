using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Domain.Model;

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

        [HttpPost("create-party")]
        public async Task<IActionResult> CreateParty(PartyDto partyDto)
        {
            await _partyService.CreateParty(partyDto);

            return Ok();
        }

        [HttpGet("parties")]
        public async Task<IActionResult> GetAllParties()
        {
            var parties = await _partyService.GetAllParties();
            return Ok(parties);
        }
    }
}
