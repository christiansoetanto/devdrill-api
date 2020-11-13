using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDrillWebAPI.Entities.DevDrillDB;
using DevDrillWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevDrillWebAPI.Services
{
    public class CourseService
    {
        private readonly DevDrillDbContext dbContext;

        public CourseService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<CourseModel>> GetCourses(int trackId)
        {
            var courses = await dbContext.Course
                .Where(e => e.TrackId == trackId)
                .Select(e => new CourseModel()
                {
                    CourseDescription = e.CourseDescription,
                    CourseId = e.CourseId,
                    CourseImage = e.CourseImage,
                    CourseName = e.CourseName,
                    DateAdded = e.DateAdded,
                    InstructorId = e.InstructorId,
                    TrackId = e.TrackId,
                    Instructor = dbContext.Instructor
                        .Where(i => i.InstructorId == e.InstructorId)
                        .Select(i => new InstructorModel()
                        {
                            InstructorId = i.InstructorId,
                            InstructorImage = i.InstructorImage,
                            InstructorName = i.InstructorName
                        }).FirstOrDefault()
                }).ToListAsync();

            return courses;
        }
    }
}