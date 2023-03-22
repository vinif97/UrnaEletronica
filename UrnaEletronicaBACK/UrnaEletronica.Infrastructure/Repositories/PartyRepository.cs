using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.Infrastructure.Repositories
{
    public class PartyRepository : IPartyRepository
    {
        private readonly EletronicUrnContext _context;

        public PartyRepository(EletronicUrnContext context)
        {
            _context = context;
        }

        public async Task CreateParty(Party party)
        {
            _context.Add(party);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Party>> GetAllParties()
        {
            var parties = await _context.Parties.Select(party => new Party()
            {
                PartyId = party.PartyId,
                Name = party.Name,
                Acronym = party.Acronym,
                Description = party.Description,
                Candidates = party.Candidates
            }).ToListAsync();

            return parties;
        }
    }
}
