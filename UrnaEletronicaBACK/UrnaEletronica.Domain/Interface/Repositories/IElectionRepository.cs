using System.Threading.Tasks;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Interface.Repositories
{
    public interface IElectionRepository
    {
        Task CreateElection(Election election);
        Task<Election?> GetElection(int electionYear);
        Task<Election?> GetElectionData(int electionYear);
    }
}
