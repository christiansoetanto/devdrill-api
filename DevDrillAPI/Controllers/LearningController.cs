using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using System.Linq;


namespace DevDrillAPI.Controllers
{
    [Route("learning")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        private readonly LearningService learningService;

        public LearningController(LearningService learningService)
        {
            this.learningService = learningService;
        }

        public async Task<IActionResult> GetCourses(int trackId)
        {
            return Ok(await learningService.GetCourses(trackId) ?? new List<CourseDto>());
        }

        public async Task<IActionResult> GetLessons(int courseId)
        {
            return Ok(await learningService.GetLessons(courseId) ?? new List<LessonGroupDto>());
        }

        public async Task<IActionResult> GetLesson(int lessonId)
        {
            return Ok(await learningService.GetLesson(lessonId) ?? new LessonDto());
        }

        public async Task<IActionResult> GetTracks()
        {
            return Ok(await learningService.GetTracks() ?? new List<TrackGroupDto>());
        }
    }
}