using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Interfaces.Services
{
    public interface IPartyService
    {
        Task<IResult> CreateParty(PartyDto partyDto);
        Task<IEnumerable<Party>> GetAllParties();
    }
}
