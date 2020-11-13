using System.Collections.Generic;
using System.Threading.Tasks;
using DevDrillWebAPI.Models;
using DevDrillWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevDrillWebAPI.Controllers
{
    [Route("course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService courseService;

        public CourseController(CourseService courseService)
        {
            this.courseService = courseService;
        }


        [HttpGet]
        public async Task<IActionResult> GetCourses(int trackId)
        {
            List<CourseModel> courses = await courseService.GetCourses(trackId);
            return Ok(courses);    
        }

    }
}