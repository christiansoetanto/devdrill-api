using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class Instructor
    {
        public Instructor()
        {
            Course = new HashSet<Course>();
        }

        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorImage { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
