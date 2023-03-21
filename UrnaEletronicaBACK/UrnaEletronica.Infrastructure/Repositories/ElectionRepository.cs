using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.Infrastructure.Repositories
{
    public class ElectionRepository : IElectionRepository
    {
        private readonly EletronicUrnContext _context;

        public ElectionRepository(EletronicUrnContext context)
        {
            _context = context;
        }

        public async Task CreateElection(Election election)
        {
            _context.Elections.Add(election);
            await _context.SaveChangesAsync();
        }

        public async Task<Election?> GetElection(int electionYear)
        {
            return await _context.Elections.FirstOrDefaultAsync(election => election.ElectionYear == electionYear);
        }

        public async Task<Election?> GetElectionData(int electionYear)
        {
            Election? election = await _context.Elections.AsNoTracking().Include(election => election.ElectionCycles)
                !.ThenInclude(electionCycle => electionCycle.Candidates)
                .FirstOrDefaultAsync(election => election.ElectionYear == electionYear);

            return election;
        }
    }
}
