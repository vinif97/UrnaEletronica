using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Application.Interfaces.Services;
using UrnaEletronica.Application.Interfaces.ValidationHandler;

namespace UrnaEletronica.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp(UserSignUpDto userSignUpDto)
        {
            IResult result = await _userService.SignUpUser(userSignUpDto);

            if (result.IsSuccess)
                return Ok();
            return BadRequest(result.Errors);
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn(UserSignInDto userSignUpDto)
        {
            (IResult result, string token) = await _userService.SignInUser(userSignUpDto);

            if (result.IsSuccess)
                return Ok(token);

            return BadRequest(result.Errors);
        }
    }
}
