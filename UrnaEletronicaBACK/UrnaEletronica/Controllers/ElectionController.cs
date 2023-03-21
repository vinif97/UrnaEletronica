using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Domain.Model;

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

        [Authorize(Roles = "admin")]
        [HttpPost("start-election")]
        public async Task<IActionResult> StartElection(StartElectionDto electionDto)
        {
            IResult result = await _electionService.StartElection(electionDto);

            if (result.IsSuccess)
                return Ok();

            return BadRequest(result);
        }

        [Authorize(Roles = "admin,citizen")]
        [HttpGet("get-election/{electionYear:int}")]
        public async Task<IActionResult> GetElection(int electionYear)
        {
            Election? election = await _electionService.GetElection(electionYear);

            if (election is null)
                return NotFound();

            return Ok(election);
        }
    }
}
