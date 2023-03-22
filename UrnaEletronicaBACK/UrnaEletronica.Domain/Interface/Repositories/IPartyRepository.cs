using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Interface.Repositories
{
    public interface IPartyRepository
    {
        Task CreateParty(Party party);
        Task<IEnumerable<Party>> GetAllParties();
    }
}
