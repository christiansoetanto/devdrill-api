using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevDrillAPI.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            UserDto res = await userService.Login(userDto.Email, userDto.Password);
            if (res == null)
            {
                return NotFound(new ProblemDetails()
                {
                    Detail = "User not found."
                });
            }

            return Ok(res);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            await userService.Register(userDto.Name, userDto.Email, userDto.PhoneNumber, userDto.Password);
            return Ok();
        }
    }
}