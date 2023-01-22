using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<IResult> SignUpUser(UserSignUpDto userSignUpDto);
        Task<(IResult, string)> SignInUser(UserSignInDto userSignInDto);
    }
}
