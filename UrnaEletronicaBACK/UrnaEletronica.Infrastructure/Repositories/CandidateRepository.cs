using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.Infrastructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly EletronicUrnContext _context;

        public CandidateRepository(EletronicUrnContext context)
        {
            _context = context;
        }
    }
}
