using System.Threading.Tasks;
using DevDrillWebAPI.Models;
using DevDrillWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevDrillWebAPI.Controllers
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
        public async Task<IActionResult> Login(string username, string password)
        {
            UserModel user = await userService.Login(username, password);
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            await userService.Register(username, password);
            return Ok();
        }
    }
}