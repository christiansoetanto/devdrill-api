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
                .AsNoTracking()
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
                .AsNoTracking()
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
                .AsNoTracking()
                .ToListAsync();
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

        public async Task<List<CourseDto>> GetLatestCourses()
        {
            return await dbContext.Courses
                .Include(e => e.Track)
                .Include(e => e.Instructor)
                .ThenInclude(e => e.User)
                .OrderByDescending(e => e.InsertDate)
                .Take(5)
                .Select(e => new CourseDto()
                {
                    Name = e.Name,
                    CourseId = e.CourseId,
                    InsertDate = e.InsertDate,
                    PhotoUrl = e.PhotoUrl,
                    TrackId = e.TrackId,
                    Instructor = new InstructorDto()
                    {
                        Name = e.Instructor.User.Name,
                    },
                    Track = new TrackDto()
                    {
                        Name = e.Track.Name,
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task UpsertMappingUserCourse(int userId, int courseId, int progress)
        {
            var find = await dbContext.MappingUserCourses
                .Where(e => e.UserId == userId)
                .Where(e => e.CourseId == courseId)
                .FirstOrDefaultAsync();
            if (find != null)
            {
                find.Progress = progress;
            }
            else
            {
                await dbContext.AddAsync(new MappingUserCourse()
                {
                    CourseId = courseId,
                    UserId = userId,
                    Progress = progress
                });
            }
          
            await dbContext.SaveChangesAsync();
        }

        public async Task UpsertMappingUserTrack(int userId, int trackId, int progress)
        {
            var find = await dbContext.MappingUserTracks
                .Where(e => e.UserId == userId)
                .Where(e => e.TrackId == trackId)
                .FirstOrDefaultAsync();
            if (find != null)
            {
                find.Progress = progress;
            }
            else
            {
                await dbContext.AddAsync(new MappingUserTrack()
                {
                    TrackId = trackId,
                    UserId = userId,
                    Progress = progress
                }); 
            }

           
            await dbContext.SaveChangesAsync();
        }
    }
}