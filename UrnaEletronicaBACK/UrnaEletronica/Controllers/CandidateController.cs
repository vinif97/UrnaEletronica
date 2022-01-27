using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrnaEletronica.Model;
using UrnaEletronica.Data;
using System.Threading.Tasks;

namespace UrnaEletronica.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateRepository _repository;

        public CandidateController(ICandidateRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult> InsertCandidate(Candidate candidate)
        {
            await _repository.InsertCandidate(candidate);

            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCandidate(Candidate candidate)
        {
            if (candidate == null) return NotFound();

            await _repository.DeleteCandidate(candidate);

            return NoContent();
        }
    }
}
