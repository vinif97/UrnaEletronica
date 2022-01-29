using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrnaEletronica.Model;
using UrnaEletronica.Data;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;

namespace UrnaEletronica.Controllers
{
    [Route("api/candidate")]
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
            try
            {
                await _repository.InsertCandidate(candidate);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao tentar inserir o candidato no banco de dados.");
            }
            
        }

        [HttpDelete("{label}")]
        public async Task<ActionResult> DeleteCandidate(int label)
        {
            try
            {
                Candidate candidate = await _repository.GetCandidateByLabel(label);

                if (candidate == null) return NotFound();

                await _repository.DeleteCandidate(candidate);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao tentar deletar o candidato do banco de dados.");
            }
            
        }
    }
}
