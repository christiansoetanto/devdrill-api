using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class InstructorDto
    {
        public int UserId { get; set; }
        public int InstructorId { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public List<CourseDto> Courses { get; set; }
        public string Name { get; set; }
    }
}