﻿using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;
using UrnaEletronica.Application.ValidationHandler;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Security;
using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IMapper mapper, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<IResult> SignUpUser(UserSignUpDto userSignUpDto)
        {
            User user = _mapper.Map<User>(userSignUpDto);
            
            IResult operationResult = SignUpUserValidationHandler.ValidateNewUser(user);

            if (!operationResult.IsSuccess)
                return operationResult;

            (string hashedPassword, byte[] salt) = PasswordHash.HashPassword(user.Password.PasswordString ?? throw new ArgumentNullException());
            user.Password.SetPasswordSalt(salt);

            await _userRepository.CreateUserAsync(user);

            return operationResult;
        }

        public async Task<(IResult, string)> SignInUser(UserSignInDto userSignIn)
        {
            string token = "";
            IResult operationResult = new OperationResult();

            User? user = await _userRepository.FindByEmailAsync(userSignIn.Email ?? throw new ArgumentNullException());

            if (user is null)
            {
                operationResult.Errors.Add("No user registered with this email");
                return (operationResult, token);
            }

#pragma warning disable CS8604 // Has null validation
            bool isPasswordValid = PasswordHash.VerifyPassword(user.Password.PasswordSalt, user.Password.PasswordString, userSignIn.Password);
#pragma warning restore CS8604 // Has null validation

            if (!isPasswordValid)
            {
                operationResult.Errors.Add("Invalid email or password");
                return (operationResult, token);
            }

            token = CreateToken(userSignIn.Email, user.Role);


            operationResult.IsSuccess = true;
            return (operationResult, token);
        }

        private string CreateToken(string email, string role)
        {
            string audience = _configuration["TokenConfiguration:Audience"];
            string issuer = _configuration["TokenConfiguration:Issuer"];
            byte[] key = Encoding.ASCII.GetBytes(_configuration["TokenConfiguration:Key"]);
            DateTime expirationTime = DateTime.UtcNow.AddHours(double.Parse(_configuration["TokenConfiguration:ExpireHours"]));
            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, email),
                new Claim("roles", role)
            };

            JwtSecurityToken securityToken = new(
                issuer: issuer,
                audience: audience,
                expires: expirationTime,
                claims: claims,
                signingCredentials: credentials
            );

            string tokenToReturn = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return tokenToReturn;
        }
    }
}
