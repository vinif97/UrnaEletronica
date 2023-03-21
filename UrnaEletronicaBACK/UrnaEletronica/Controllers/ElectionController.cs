using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;

namespace UrnaEletronica.WebApi.Controllers
{
    [Route("api/election")]
    [ApiController]
    public class ElectionController : ControllerBase
    {
        private readonly IElectionService _electionService;

        public ElectionController(IElectionService electionService)
        { 
            _electionService = electionService;
        }

        [HttpPost("start-election")]
        public async Task<IActionResult> StartElection(StartElectionDto electionDto)
        {
            IResult result = await _electionService.StartElection(electionDto);

            if (result.IsSuccess)
                return Ok();

            return BadRequest(result);
        }

        [HttpGet("get-election")]
        public async Task<IActionResult> GetElection(int electionYear)
        {
            return NoContent();
        }
    }
}
