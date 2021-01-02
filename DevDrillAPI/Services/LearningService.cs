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

        public async Task<List<LessonGroupDto>> GetLessonGroupsByCourseId(int courseId)
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
                        StartDateTime = l.StartDateTime,
                        VideoUrl = l.VideoUrl,
                        VideoType = l.VideoType,
                        Detail = l.Detail
                    }).ToList()
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<LessonGroupDto> GetLessonGroup(int id)
        {
            return await dbContext.LessonGroups
                .Where(e => e.LessonGroupId == id)
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
                        StartDateTime = l.StartDateTime,
                        VideoUrl = l.VideoUrl,
                        VideoType = l.VideoType,
                        Detail = l.Detail
                    }).ToList()
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<LessonDto> GetLesson(int id)
        {
            return await dbContext.Lessons
                .Where(e => e.LessonId == id)
                .Select(e => new LessonDto()
                {
                    Name = e.Name,
                    LessonId = e.LessonId,
                    Detail = e.Detail,
                    VideoUrl = e.VideoUrl,
                    VideoType = e.VideoType,
                    ThumbnailUrl = e.ThumbnailUrl,
                    EndDateTime = e.EndDateTime,
                    StartDateTime = e.StartDateTime
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
        public async Task<List<CourseDto>> GetCourses()
        {
            return await dbContext.Courses
                .Include(e => e.Instructor)
                .ThenInclude(i => i.User)
                .Select(e => new CourseDto()
                {
                    Detail = e.Detail,
                    Name = e.Name,
                    CourseId = e.CourseId,
                    PhotoUrl = e.PhotoUrl,
                    CoverUrl = e.CoverUrl,
                    InsertDate = e.InsertDate,
                    User = new UserDto()
                    {
                        UserId = e.Instructor.User.UserId,
                        Name = e.Instructor.User.Name,
                        Instructor = new InstructorDto
                        {
                            CompanyName = e.Instructor.CompanyName,
                            InstructorId = e.Instructor.InstructorId,
                            Title = e.Instructor.Title
                        }
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<List<CourseDto>> GetCoursesByTrackId(int trackId)
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
                    CoverUrl = e.CoverUrl,
                    InsertDate = e.InsertDate,
                    User = new UserDto()
                    {
                        UserId = e.Instructor.User.UserId,
                        Name = e.Instructor.User.Name,
                        Instructor = new InstructorDto
                        {
                            CompanyName = e.Instructor.CompanyName,
                            InstructorId = e.Instructor.InstructorId,
                            Title = e.Instructor.Title
                        }
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<CourseDto> GetCourse(int id)
        {
            return await dbContext.Courses
                .Where(e => e.CourseId == id)
                .Include(e => e.Instructor)
                .ThenInclude(i => i.User)
                .Select(e => new CourseDto()
                {
                    Detail = e.Detail,
                    Name = e.Name,
                    CourseId = e.CourseId,
                    PhotoUrl = e.PhotoUrl,
                    CoverUrl = e.CoverUrl,
                    InsertDate = e.InsertDate,
                    User = new UserDto()
                    {
                        UserId = e.Instructor.User.UserId,
                        Name = e.Instructor.User.Name,
                        Instructor = new InstructorDto
                        {
                            CompanyName = e.Instructor.CompanyName,
                            InstructorId = e.Instructor.InstructorId,
                            Title = e.Instructor.Title
                        }
                    }
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<List<TrackGroupDto>> GetTracks()
        {
            var x = await dbContext.TrackGroups
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
                })
                .AsNoTracking()
                .ToListAsync();

            return x;
        }
        public async Task<TrackDto> GetTrack(int id)
        {
            return await dbContext.Tracks
                .Where(e => e.TrackId == id)
                .Select(e => new TrackDto
                {
                    TrackId = e.TrackId,
                    Name = e.Name,
                    Detail = e.Detail,
                    PhotoUrl = e.PhotoUrl,
                    TrackGroupId = e.TrackGroupId,
                    TrackGroup = null
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<List<CourseDto>> GetLatestCourses()
        {
            return await dbContext.Courses
                .Include(e => e.Track)
                .Include(e => e.Instructor)
                .ThenInclude(e => e.User)
                .OrderByDescending(e => e.InsertDate)
                .Take(10)
                .Select(e => new CourseDto()
                {
                    Name = e.Name,
                    CourseId = e.CourseId,
                    InsertDate = e.InsertDate,
                    PhotoUrl = e.PhotoUrl,
                    CoverUrl = e.CoverUrl,
                    TrackId = e.TrackId,
                    User = new UserDto()
                    {
                        UserId = e.Instructor.User.UserId,
                        Name = e.Instructor.User.Name,
                        Instructor = new InstructorDto
                        {
                            CompanyName = e.Instructor.CompanyName,
                            InstructorId = e.Instructor.InstructorId,
                            Title = e.Instructor.Title
                        }
                    },
                    Track = new TrackDto()
                    {
                        Name = e.Track.Name,
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }

    }
}