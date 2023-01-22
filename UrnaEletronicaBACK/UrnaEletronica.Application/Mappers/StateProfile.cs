using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class StateProfile : Profile
    {
        public StateProfile()
        {
            CreateMap<State, StateDto>().ReverseMap();
        }
    }
}
