using System;

namespace DevDrillWebAPI.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImage { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? TrackId { get; set; }
        public int? InstructorId { get; set; }
        
        public InstructorModel Instructor { get; set; }
    }
}