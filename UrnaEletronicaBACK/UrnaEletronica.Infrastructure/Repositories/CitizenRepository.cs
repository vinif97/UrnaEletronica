using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.Infrastructure.Repositories
{
    public class CitizenRepository : ICitizenRepository
    {
        private readonly EletronicUrnContext _context;

        public CitizenRepository(EletronicUrnContext context)
        {
            _context = context;
        }
    }
}
