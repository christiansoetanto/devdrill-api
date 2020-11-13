using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class Course
    {
        public Course()
        {
            LessonGroup = new HashSet<LessonGroup>();
            MappingUserCourse = new HashSet<MappingUserCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImage { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? TrackId { get; set; }
        public int? InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Track Track { get; set; }
        public virtual ICollection<LessonGroup> LessonGroup { get; set; }
        public virtual ICollection<MappingUserCourse> MappingUserCourse { get; set; }
    }
}
