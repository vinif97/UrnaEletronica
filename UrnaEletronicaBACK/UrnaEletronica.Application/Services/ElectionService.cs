﻿using AutoMapper;
using System.Formats.Asn1;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Services
{
    public class ElectionService : IElectionService
    {
        private readonly IElectionRepository _electionRepository;
        private readonly ICitizenRepository _citizenRepository;
        private readonly IMapper _mapper;

        public ElectionService(IElectionRepository electionRepository, IMapper mapper, ICitizenRepository citizenRepository)
        {
            _electionRepository = electionRepository;
            _mapper = mapper;
            _citizenRepository = citizenRepository;
        }

        public async Task<IResult> StartElection(StartElectionDto electionDto)
        {
            IResult operationResult = new OperationResult();

            Election election = _mapper.Map<Election>(electionDto);
            try
            {
                await _electionRepository.CreateElection(election);
            }
            catch (Exception ex)
            {
                operationResult.IsSuccess = false;
                operationResult.Errors.Add(ex.Message);
            }

            return operationResult;
        }

        public async Task<Election?> GetElection(int electionYear)
        {
            Election? election = await _electionRepository.GetElectionData(electionYear);

            return election;
        }

        public async Task<IResult> Vote(Citizen citizen, ElectionCycle electionCycle)
        {
            throw new NotImplementedException();
        }
    }
}
