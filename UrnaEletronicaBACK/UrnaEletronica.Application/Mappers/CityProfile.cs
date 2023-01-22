using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDto>().ReverseMap();
        }
    }
}
