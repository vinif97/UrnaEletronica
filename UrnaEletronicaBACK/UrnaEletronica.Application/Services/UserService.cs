using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Security;

namespace UrnaEletronica.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IResult> SignUpUser(UserSignUpDto userSignUpDto)
        {
            User user = _mapper.Map<User>(userSignUpDto);
            
            IResult operationResult = SignUpUserValidationHandler.ValidateNewUser(user);

            if (!operationResult.IsSuccess)
                return operationResult;

#pragma warning disable CS8604 // Has null validation.
            (string hashedPassword, byte[] salt) = PasswordHash.HashPassword(user.Password);
#pragma warning restore CS8604 // Has null validation.
            user.PasswordSalt = salt;
            user.Password = hashedPassword;
            user.ConfirmPassword = hashedPassword;

            await _userRepository.CreateUserAsync(user);

            return operationResult;
        }

        public async Task<User?> SignInUser(UserSignInDto Sign)
        {
            User? user = await _userRepository.FindByEmailAsync(Sign.Email);

            return user;
        }
    }
}
