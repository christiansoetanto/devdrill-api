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
        [HttpGet("tracks/{trackId}/courses")]
        public async Task<IActionResult> GetCourses(int trackId)
        {
            return Ok(await learningService.GetCourses(trackId) ?? new List<CourseDto>());
        }
        [HttpGet("courses/{courseId}/lessons")]
        public async Task<IActionResult> GetLessons(int courseId)
        {
            return Ok(await learningService.GetLessons(courseId) ?? new List<LessonGroupDto>());
        }
        [HttpGet("lessons/{lessonId}")]
        public async Task<IActionResult> GetLesson(int lessonId)
        {
            return Ok(await learningService.GetLesson(lessonId) ?? new LessonDto());
        }
        [HttpGet("tracks")]
        public async Task<IActionResult> GetTracks()
        {
            return Ok(await learningService.GetTracks() ?? new List<TrackGroupDto>());
        }
    }
}