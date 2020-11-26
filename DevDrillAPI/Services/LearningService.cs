using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace DevDrillAPI.Services
{
    public class LearningService
    {
        private readonly DevDrillDbContext dbContext;

        public LearningService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<LessonGroupDto>> GetLessons(int courseId)
        {
            return await dbContext.LessonGroups
                .Where(e => e.CourseId == courseId)
                .Include(e => e.Lessons)
                .Select(e => new LessonGroupDto()
                {
                    LessonGroupId = e.LessonGroupId,
                    LessonGroupName = e.LessonGroupName,
                    Lessons = e.Lessons.Select(l => new LessonDto()
                    {
                        Name = l.Name,
                        LessonId = l.LessonId,
                        ThumbnailUrl = l.ThumbnailUrl,
                        EndDateTime = l.EndDateTime,
                        StartDateTime = l.StartDateTime
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<LessonDto> GetLesson(int lessonId)
        {
            return await dbContext.Lessons
                .Where(e => e.LessonId == lessonId)
                .Select(e => new LessonDto()
                {
                    Name = e.Name,
                    LessonId = e.LessonId,
                    Detail = e.Detail,
                    VideoUrl = e.VideoUrl,
                    ThumbnailUrl = e.ThumbnailUrl,
                    EndDateTime = e.EndDateTime,
                    StartDateTime = e.StartDateTime
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<CourseDto>> GetCourses(int trackId)
        {
            return await dbContext.Courses
                .Where(e => e.TrackId == trackId)
                .Include(e => e.Instructor)
                .ThenInclude(i => i.User)
                .Select(e => new CourseDto()
                {
                    Detail = e.Detail,
                    Name = e.Name,
                    CourseId = e.CourseId,
                    PhotoUrl = e.PhotoUrl,
                    InsertDate = e.InsertDate,
                    Instructor = new InstructorDto()
                    {
                        Title = e.Instructor.Title,
                        CompanyName = e.Instructor.CompanyName,
                        InstructorId = e.Instructor.InstructorId,
                        Name = e.Instructor.User.Name
                    }
                })
                .ToListAsync();
        }

        public async Task<List<TrackGroupDto>> GetTracks()
        {
            return await dbContext.TrackGroups
                .Include(e => e.Tracks)
                .Select(e => new TrackGroupDto()
                {
                    TrackGroupId = e.TrackGroupId,
                    TrackGroupName = e.TrackGroupName,
                    Tracks = e.Tracks.Select(t => new TrackDto()
                    {
                        TrackGroupId = t.TrackGroupId,
                        Detail = t.Detail,
                        Name = t.Name,
                        PhotoUrl = t.PhotoUrl,
                        TrackId = t.TrackId
                    }).ToList()
                }).ToListAsync();
        }
    }
}