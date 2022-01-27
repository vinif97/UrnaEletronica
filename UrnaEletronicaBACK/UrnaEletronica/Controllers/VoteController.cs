using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrnaEletronica.Model;
using UrnaEletronica.Data;
using System.Threading.Tasks;

namespace UrnaEletronica.Controllers
{
    [ApiController]
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
            IEnumerable<Candidate> candidates = await _repository.GetVotesByCandidates();

            return Ok(candidates);
        }

        [HttpPost("vote")]
        public async Task<ActionResult> InsertVote(Vote vote)
        {
            await _repository.InsertVote(vote);

            return Ok();
        }
    }
}
