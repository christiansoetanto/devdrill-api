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
            List<CourseDto> courseDtos = await learningService.GetCourses(trackId);
            if (courseDtos == null)
                return NotFound(new ProblemDetails()
                {
                    Detail = "Courses not found."
                });

            return Ok(courseDtos);
        }

        public async Task<IActionResult> GetLessons(int courseId)
        {
            List<LessonGroupDto> lessonGroupDtos = await learningService.GetLessons(courseId);
            if (lessonGroupDtos.Any())
                return Ok(lessonGroupDtos);
            return NotFound(new ProblemDetails()
            {
                Detail = "No Data Found."
            });
        }

        public async Task<IActionResult> GetLesson(int lessonId)
        {
            LessonDto lessonDto = await learningService.GetLesson(lessonId);
            if (lessonDto == null)
                return NotFound(new ProblemDetails()
                {
                    Detail = "No Data Found."
                });
            return Ok(lessonDto);
        }

        public async Task<IActionResult> GetTracks()
        {
            List<TrackGroupDto> trackGroupDtos = await learningService.GetTracks();
            if (trackGroupDtos.Any()) return Ok(trackGroupDtos);
            return NotFound(new ProblemDetails()
            {
                Detail = "No Data Found."
            });
        }
    }
}