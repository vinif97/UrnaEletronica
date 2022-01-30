using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrnaEletronica.Model;
using UrnaEletronica.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using UrnaEletronica.Repository;

namespace UrnaEletronica.Controllers
{
    [ApiController]
    [Route("api")]
    public class VoteController : ControllerBase
    {
        private readonly IVoteRepository _repository;

        public VoteController(IVoteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("votes")]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetVotesByCandidates()
        {
            try
            {
                IEnumerable<Candidate> candidates = await _repository.GetVotesByCandidates();
                return Ok(candidates);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao tentar obter os candidatos do banco de dados");
            }
        }

        [HttpPost("vote")]
        public async Task<ActionResult> InsertVote(Vote vote)
        {
            if (vote == null) return BadRequest("Erro nos dados enviados.");

            try
            {
                await _repository.InsertVote(vote);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao tentar computar o voto.");
            }
        }
    }
}
