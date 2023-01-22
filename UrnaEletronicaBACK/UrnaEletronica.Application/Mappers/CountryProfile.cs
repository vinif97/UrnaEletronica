using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
        }
    }
}
