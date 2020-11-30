using System.Collections.Generic;
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

        [HttpGet("detail/{userId}")]
        public async Task<IActionResult> GetUserDetail(int userId)
        {
            var user = await userService.GetUserDetail(userId);
            if (user == null)
            {
                return NotFound(new ProblemDetails()
                {
                    Detail = "User not found."
                });
            }

            return Ok(user);
        }

        [HttpGet("courses/{userId}")]
        public async Task<IActionResult> GetUserCourses(int userId)
        {
            return Ok(await userService.GetUserCourses(userId) ?? new List<MappingUserCourseDto>());
        }

        [HttpGet("tracks/{userId}")]
        public async Task<IActionResult> GetUserTracks(int userId)
        {
            return Ok(await userService.GetUserTracks(userId) ?? new List<MappingUserTrackDto>());
        }

        [HttpGet("threads/{userId}")]
        public async Task<IActionResult> GetUserThreads(int userId)
        {
            return Ok(await userService.GetUserThreads(userId) ?? new List<ThreadDto>());
        }
    }
}