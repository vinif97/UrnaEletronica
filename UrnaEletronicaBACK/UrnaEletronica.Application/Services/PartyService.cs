using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Services
{
    public class PartyService : IPartyService
    {
        private readonly IPartyRepository _partyRepository;
        private readonly IMapper _mapper;

        public PartyService(IMapper mapper, IPartyRepository partyRepository)
        {
            _partyRepository = partyRepository;
            _mapper = mapper;
        }

        public async Task<IResult> CreateParty(PartyDto partyDto)
        {
            IResult result = new OperationResult();
            Party party = _mapper.Map<Party>(partyDto);

            try
            {
                await _partyRepository.CreateParty(party);
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Errors.Add(ex.InnerException?.Message ?? ex.Message);

                return result;
            }
            

            return result;
        }

        public async Task<IEnumerable<Party>> GetAllParties()
        {
            var parties = await _partyRepository.GetAllParties();

            return parties;
        }
    }
}
