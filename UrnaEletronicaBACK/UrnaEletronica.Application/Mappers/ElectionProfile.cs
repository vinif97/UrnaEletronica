using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class ElectionProfile : Profile
    {
        public ElectionProfile()
        {
            CreateMap<Election, StartElectionDto>().ReverseMap();
        }
    }
}
