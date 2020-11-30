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

        public async Task<UserDto> GetUserDetail(int userId)
        {
            return await dbContext.Users
                .Where(e => e.UserId == userId)
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

        public async Task<List<MappingUserCourseDto>> GetUserCourses(int userId)
        {
            return await dbContext.MappingUserCourses
                .Where(e => e.UserId == userId)
                .Include(e => e.Course)
                .Select(e => new MappingUserCourseDto()
                {
                    CourseId = e.Course.CourseId,
                    UserId = e.UserId,
                    Course = new CourseDto()
                    {
                        Name = e.Course.Name,
                    },
                    Progress = e.Progress
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<MappingUserTrackDto>> GetUserTracks(int userId)
        {
            return await dbContext.MappingUserTracks
                .Where(e => e.UserId == userId)
                .Include(e => e.Track)
                .Select(e => new MappingUserTrackDto()
                {
                    Progress = e.Progress,
                    TrackId = e.TrackId,
                    Track = new TrackDto()
                    {
                        Name = e.Track.Name
                    }
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<ThreadDto>> GetUserThreads(int userId)
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
    }
}