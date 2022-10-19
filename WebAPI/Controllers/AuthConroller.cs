using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Dtos.User;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthConroller: ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthConroller(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Resgister(
                new User { Username = request.Username}, request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);    
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username,request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}
