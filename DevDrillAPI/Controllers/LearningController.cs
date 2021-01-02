using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.Json;

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
        [HttpGet("courses")]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await learningService.GetCourses() ?? new List<CourseDto>());
        }
        [HttpGet("courses/{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            return Ok(await learningService.GetCourse(id) ?? new CourseDto());
        }
        [HttpGet("tracks/{trackId}/courses")]
        public async Task<IActionResult> GetCoursesByTrackId(int trackId)
        {
            return Ok(await learningService.GetCoursesByTrackId(trackId) ?? new List<CourseDto>());
        }

        [HttpGet("courses/{courseId}/lesson-groups")]
        public async Task<IActionResult> GetLessonGroupsByCourseId(int courseId)
        {
            return Ok(await learningService.GetLessonGroupsByCourseId(courseId) ?? new List<LessonGroupDto>());
        }

        [HttpGet("lesson-groups/{id}")]
        public async Task<IActionResult> GetLessonGroup(int id)
        {
            return Ok(await learningService.GetLessonGroup(id) ?? new LessonGroupDto());
        }

        [HttpGet("lessons/{id}")]
        public async Task<IActionResult> GetLesson(int id)
        {
            return Ok(await learningService.GetLesson(id) ?? new LessonDto());
        }

        [HttpGet("tracks")]
        public async Task<IActionResult> GetTracks()
        {
            return Ok(await learningService.GetTracks() ?? new List<TrackGroupDto>());
        }
        [HttpGet("tracks/{id}")]
        public async Task<IActionResult> GetTrack(int id)
        {
            return Ok(await learningService.GetTrack(id) ?? new TrackDto());
        }

        [HttpGet("latest-courses")]
        public async Task<IActionResult> GetLatestCourses()
        {
            return Ok(await learningService.GetLatestCourses() ?? new List<CourseDto>());
        }

    }
}