using System.Collections.Generic;
using System.Threading.Tasks;
using DevDrillWebAPI.Models;
using DevDrillWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevDrillWebAPI.Controllers
{
    [Route("lesson")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly LessonService lessonService;

        public LessonController(LessonService lessonService)
        {
            this.lessonService = lessonService;
        }

        [HttpGet("{courseId}")]
        public async Task<IActionResult> GetLesson(int courseId)
        {
            List<LessonGroupModel> lessonGroups = await lessonService.GetLessons(courseId);
            return Ok(lessonGroups);
        }
    }
}