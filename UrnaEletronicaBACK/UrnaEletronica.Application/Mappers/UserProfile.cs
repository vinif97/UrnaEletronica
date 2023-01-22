using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserSignUpDto>().ReverseMap();
            CreateMap<User, UserSignInDto>().ReverseMap();
        }
    }
}
