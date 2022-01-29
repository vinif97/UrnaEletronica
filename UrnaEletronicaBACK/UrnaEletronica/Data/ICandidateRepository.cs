using UrnaEletronica.Model;
using System.Threading.Tasks;

namespace UrnaEletronica.Data
{
    public interface ICandidateRepository
    {
        Task InsertCandidate(Candidate candidate);
        Task DeleteCandidate(Candidate candidate);
        Task<Candidate> GetCandidateByLabel(int label);
    }
}
