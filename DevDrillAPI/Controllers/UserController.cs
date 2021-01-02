using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using Microsoft.AspNetCore.Mvc;
using DevDrillAPI.Helper.Extensions;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System;

namespace DevDrillAPI.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        private readonly UserService userService;

        private const string DEFAULT_PROFILE_PICTURE = "default.png";

        public UserController(UserService userService,IWebHostEnvironment environment)
        {
            this.userService = userService;
            this.environment = environment;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            UserDto res = await userService.Login(userDto.Email, userDto.Password);
            if (res == null)
            {
                return Unauthorized(new ProblemDetails()
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await userService.GetUser(id);
            if (user == null)
            {
                return NotFound(new ProblemDetails()
                {
                    Detail = "User not found."
                });
            }

            return Ok(user);
        }

        [HttpGet("{userId}/threads")]
        public async Task<IActionResult> GetThreadsByUserId(int userId)
        {
            return Ok(await userService.GetThreadsByUserId(userId) ?? new List<ThreadDto>());
        }
        [HttpGet("{userId}/threads/desc-order-by-insert-date")]
        public async Task<IActionResult> GetThreadsByUserIdWithOrderDescByInsertDate(int userId)
        {
            return Ok(await userService.GetThreadsByUserIdWithOrderDescByInsertDate(userId) ?? new List<ThreadDto>());
        }
        [HttpPost("{userId}/avatar/upload")]
        public async Task<IActionResult> UploadProfilePicture(int userId)
        {
            try
            {
                IFormFile image = Request.Form.Files[0];
                List<string> allowedExts = new List<string> { ".png", ".jpg", ".jpeg" };

                if (image.Length > 0)
                {
                    if (!allowedExts.Contains(Path.GetExtension(image.FileName)))
                        return BadRequest("Invalid Extension");
                    string uploadPath = Path.Combine(environment.ContentRootPath, "Upload", "ProfilePicture");
                    string fileName = $"{userId}{Path.GetExtension(image.FileName)}";
                    string filePath = Path.Combine(uploadPath, fileName);
                    var fileStream = new FileStream(filePath, FileMode.Create);
                    await image.CopyToAsync(fileStream); fileStream.Close(); fileStream.Dispose();
                    await userService.UpdatePhoto(fileName, userId);
                }
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, new
                {
                    Detail = e.Message
                });
            }
        }
        [HttpGet("{userId}/avatar")]
        public async Task<IActionResult> GetProfilePicture(int userId)
        {
            try
            {
                UserDto user = await userService.GetUser(userId);
                string uploadPath = Path.Combine(environment.ContentRootPath, "Upload", "ProfilePicture");
                string fileName = String.IsNullOrEmpty(user.PhotoUrl) ? DEFAULT_PROFILE_PICTURE : user.PhotoUrl;
                string filePath = Path.Combine(uploadPath, fileName);

                if (System.IO.File.Exists(filePath))
                {
                    FileStream image = System.IO.File.OpenRead(filePath);
                    return File(image, $"image/{Path.GetExtension(fileName).Replace(".", "")}");
                }
                return NotFound();
            }
            catch(Exception e)
            {
                return StatusCode(500, new
                {
                    Detail = e.Message
                });
            }
        }

        [HttpPost("progress")]
        public async Task<IActionResult> SetLessonAsDone([FromBody] JsonElement body)
        {
            try
            {
                int lessonId = body.GetProperty("lessonId").GetInt32();
                int userId = body.GetProperty("userId").GetInt32();
                await userService.SetLessonAsDone(lessonId, userId);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500,new { 
                    Detail = e.Message
                });
            }
        }
        [HttpGet("{userId}/progress/lessons/{lessonId}")]
        public async Task<IActionResult> GetLessonCompletion(int lessonId, int userId)
        {
            return Ok(await userService.GetLessonCompletion(lessonId, userId));
        }

        [HttpGet("{userId}/progress/courses/{courseId}")]
        public async Task<IActionResult> GetCourseCompletion(int courseId, int userId)
        {
            return Ok(await userService.GetCourseCompletion(courseId, userId));
        }

        [HttpGet("{userId}/progress/tracks/{trackId}")]
        public async Task<IActionResult> GetTrackCompletion(int trackId, int userId)
        {
            return Ok(await userService.GetTrackCompletion(trackId, userId));
        }

        [HttpGet("{userId}/courses/desc-order-by-last-active")]
        public async Task<IActionResult> GetCoursesByUserIdWithOrderDescByLastActive(int userId)
        {
            return Ok(await userService.GetCoursesByUserIdWithOrderDescByLastActive(userId));
        }

        [HttpGet("{userId}/tracks/desc-order-by-last-active")]
        public async Task<IActionResult> GetTracksByUserIdWithOrderDescByLastActive(int userId)
        {
            return Ok(await userService.GetTracksByUserIdWithOrderDescByLastActive(userId));
        }

    }
}