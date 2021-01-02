using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevDrillAPI.Services
{
    public class UserService
    {
        private readonly DevDrillDbContext dbContext;

        public UserService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<UserDto> Login(string email, string password)
        {
            return await dbContext.Users
                .Where(e => e.Email == email)
                .Where(e => e.Password == password)
                .Select(e => new UserDto()
                {
                    Email = e.Email,
                    Name = e.Name,
                    UserId = e.UserId,
                    PhotoUrl = e.PhotoUrl,
                    PhoneNumber = e.PhoneNumber
                })
                .FirstOrDefaultAsync();
        }

        public async Task Register(string name, string email, string phoneNumber, string password)
        {
            await dbContext.Users.AddAsync(new User()
            {
                Email = email,
                Name = name,
                Password = password,
                PhoneNumber = phoneNumber,
                IsInstructor = false
            });
            await dbContext.SaveChangesAsync();
        }
        public async Task UpdatePhoto(string photoUrl, int userId)
        {
            User x = await dbContext.Users.FindAsync(userId);
            if (x == null) throw new KeyNotFoundException();
            x.PhotoUrl = photoUrl;
            await dbContext.SaveChangesAsync();
        }
        public async Task<UserDto> GetUser(int id)
        {
            return await dbContext.Users
                .Where(e => e.UserId == id)
                .Include(e => e.Instructor)
                .Select(e => new UserDto()
                {
                    Email = e.Email,
                    Name = e.Name,
                    PhoneNumber = e.PhoneNumber,
                    PhotoUrl = e.PhotoUrl,
                    UserId = e.UserId,
                    Instructor = new InstructorDto()
                    {
                        Title = e.Instructor.Title,
                        CompanyName = e.Instructor.CompanyName,
                        InstructorId = e.Instructor.InstructorId
                    }
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<List<ThreadDto>> GetThreadsByUserId(int userId)
        {
            return await dbContext.Threads
                .Where(e => e.UserId == userId)
                .Include(e => e.Replies)
                .Select(e => new ThreadDto()
                {
                    ThreadId = e.ThreadId,
                    Topic = e.Topic,
                    Upvote = e.Upvote,
                    ReplyCount = e.Replies.Count
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<List<ThreadDto>> GetThreadsByUserIdWithOrderDescByInsertDate(int userId)
        {
            return await dbContext.Threads
                .Where(e => e.UserId == userId)
                .Include(e => e.User)
                .Include(e => e.Replies)
                .OrderByDescending(e => e.InsertDate)
                .Select(e => new ThreadDto
                {
                    Topic = e.Topic,
                    ThreadId = e.ThreadId,
                    Upvote = e.Upvote,
                    User = new UserDto
                    {
                        UserId = e.User.UserId,
                        Name = e.User.Name,
                        IsInstructor = e.User.IsInstructor
                    },
                    ReplyCount = e.Replies.Count,
                    DiscussionId = e.DiscussionId,
                    Detail = e.Detail,
                    InsertDate = e.InsertDate
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task SetLessonAsDone(int lessonId, int userId)
        {
            var mapping = await dbContext.MappingUserLessonDones
                .Where(x => x.LessonId == lessonId && x.UserId == userId)
                .FirstOrDefaultAsync();

            if (mapping == null)
            {
                await dbContext.MappingUserLessonDones.AddAsync(new MappingUserLessonDone
                {
                    UserId = userId,
                    LessonId = lessonId,
                    LastActive = DateTime.Now
                });
                await dbContext.SaveChangesAsync();
            }
            else
            {
                mapping.LastActive = DateTime.Now;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> GetLessonCompletion(int lessonId, int userId)
        {
            var mapping = await dbContext.MappingUserLessonDones
                .Where(x => x.LessonId == lessonId && x.UserId == userId)
                .FirstOrDefaultAsync();

            return (mapping != null);
        }

        public async Task<double> GetCourseCompletion(int courseId, int userId)
        {
            int current = await dbContext.MappingUserLessonDones
                .Include(x => x.Lesson)
                .ThenInclude(x => x.LessonGroup)
                .Where(x => x.UserId == userId && x.Lesson.LessonGroup.CourseId == courseId)
                .Select(x => x.LessonId)
                .CountAsync();

            int overall = await dbContext.Lessons
                .Include(x => x.LessonGroup)
                .Where(x => x.LessonGroup.CourseId == courseId)
                .Select(x => x.LessonId)
                .CountAsync();

            return (overall == 0) ? 0 : ((double)current / overall);
        }

        public async Task<double> GetTrackCompletion(int trackId, int userId)
        {
            int current = await dbContext.MappingUserLessonDones
                .Include(x => x.Lesson)
                .ThenInclude(x => x.LessonGroup)
                .ThenInclude(x => x.Course)
                .Where(x => x.UserId == userId && x.Lesson.LessonGroup.Course.TrackId == trackId)
                .Select(x => x.LessonId)
                .CountAsync();

            int overall = await dbContext.Lessons
                .Include(x => x.LessonGroup)
                .ThenInclude(x => x.Course)
                .Where(x => x.LessonGroup.Course.TrackId == trackId)
                .Select(x => x.LessonId)
                .CountAsync();

            return (overall == 0)? 0 : ((double)current / overall);
        }

        public async Task<List<CourseDto>> GetCoursesByUserIdWithOrderDescByLastActive(int userId)
        {
            return await dbContext.Courses.FromSqlRaw(
                "SELECT M.CourseId, M.Name, M.Detail, M.InsertDate, IFNULL(CAST(M.Total AS FLOAT)/NULLIF(N.Total,0),0) AS [Progress], [LastActive] FROM (" +
                    "SELECT X.CourseId, X.Name, X.Detail, X.InsertDate, [Total], [LastActive] FROM Courses X INNER JOIN (" +
                        "SELECT CourseId, COUNT(*) AS [Total], MAX(A.LastActive) AS [LastActive] " +
                        "FROM MappingUserLessonDones A INNER JOIN Lessons B ON A.LessonId = B.LessonId " +
                        "INNER JOIN LessonGroups C ON B.LessonGroupId = C.LessonGroupId " +
                        "WHERE A.UserId = " + userId + " " +
                        "GROUP BY CourseId " +
                    ") Y ON X.CourseId = Y.CourseId" +
                ") M INNER JOIN (" +
                    "SELECT X.CourseId, [Total] FROM Courses X INNER JOIN (" +
                        "SELECT CourseId, COUNT(*) AS [Total] " +
                        "FROM Lessons A INNER JOIN LessonGroups B ON A.LessonGroupId = B.LessonGroupId " +
                        "GROUP BY CourseId " +
                    ") Y ON X.CourseId = Y.CourseId" +
                ") N ON M.CourseId = N.CourseId " +
                "ORDER BY LastActive DESC")
                .Select(e => new CourseDto
                {
                    CourseId = e.CourseId,
                    Name = e.Name,
                    Detail = e.Detail,
                    InsertDate = e.InsertDate,
                    Progress = e.Progress
                })
                .AsNoTracking()
                .ToListAsync();

        }

        public async Task<List<TrackDto>> GetTracksByUserIdWithOrderDescByLastActive(int userId)
        {
            return await dbContext.Tracks.FromSqlRaw(
                "SELECT M.TrackId, M.Name, M.Detail, M.TrackGroupId, IFNULL(CAST(M.Total AS FLOAT)/NULLIF(N.Total,0),0) AS [Progress], [LastActive] FROM (" +
                    "SELECT X.TrackId, X.Name, X.Detail, X.TrackGroupId, [Total], [LastActive] FROM Track X INNER JOIN (" +
                        "SELECT TrackId, COUNT(*) AS [Total], MAX(A.LastActive) AS [LastActive] " +
                        "FROM MappingUserLessonDones A INNER JOIN Lessons B ON A.LessonId = B.LessonId " +
                        "INNER JOIN LessonGroups C ON B.LessonGroupId = C.LessonGroupId " +
                        "INNER JOIN Courses D ON C.CourseId = D.CourseId " +
                        "WHERE A.UserId = " + userId + " " +
                        "GROUP BY TrackId " +
                    ") Y ON X.TrackId = Y.TrackId" +
                ") M INNER JOIN (" +
                    "SELECT X.TrackId, [Total] FROM Track X INNER JOIN (" +
                        "SELECT TrackId, COUNT(*) AS [Total] " +
                        "FROM Lessons A INNER JOIN LessonGroups B ON A.LessonGroupId = B.LessonGroupId " +
                        "INNER JOIN Courses C ON B.CourseId = C.CourseId " +
                        "GROUP BY TrackId " +
                    ") Y ON X.TrackId = Y.TrackId" +
                ") N ON M.TrackId = N.TrackId " +
                "ORDER BY LastActive DESC")
                .Select(e => new TrackDto
                {
                    TrackId = e.TrackId,
                    Name = e.Name,
                    Detail = e.Detail,
                    TrackGroupId = e.TrackGroupId,
                    Progress = e.Progress
                })
                .AsNoTracking()
                .ToListAsync();

        }
    }
}