using UrnaEletronica.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using UrnaEletronica.Data;

namespace UrnaEletronica.Repository
{
    public interface IVoteRepository
    {
        Task<IEnumerable<Candidate>> GetVotesByCandidates();
        Task InsertVote(Vote vote);
        
    }
}
