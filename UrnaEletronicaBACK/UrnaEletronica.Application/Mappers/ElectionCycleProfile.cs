using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class ElectionCycleProfile : Profile
    {
        public ElectionCycleProfile()
        {
            CreateMap<ElectionCycle, StartElectionCycleDto>().ReverseMap();
        }
    }
}
