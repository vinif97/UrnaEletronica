using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Interfaces.Services
{
    public interface IElectionService
    {
        Task<IResult> StartElection(StartElectionDto electionDto);
        Task<Election?> GetElection(int electionYear);
        Task<IResult> Vote(Citizen citizen, ElectionCycle electionCycle);
    }
}
