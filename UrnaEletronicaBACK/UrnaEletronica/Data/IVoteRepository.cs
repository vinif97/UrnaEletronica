using UrnaEletronica.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrnaEletronica.Data
{
    public interface IVoteRepository
    {
        Task<IEnumerable<Candidate>> GetVotesByCandidates();
        Task InsertVote(Vote vote);
        
    }
}
