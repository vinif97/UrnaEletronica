using UrnaEletronica.Model;
using System.Threading.Tasks;
using UrnaEletronica.Data;

namespace UrnaEletronica.Repository
{
    public interface ICandidateRepository
    {
        Task InsertCandidate(Candidate candidate);
        Task DeleteCandidate(Candidate candidate);
        Task<Candidate> GetCandidateByLabel(CandidateDelete candidateDelete);
    }
}
