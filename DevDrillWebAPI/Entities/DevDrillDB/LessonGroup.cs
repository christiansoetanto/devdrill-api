using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class LessonGroup
    {
        public LessonGroup()
        {
            Lesson = new HashSet<Lesson>();
        }

        public int LessonGroupId { get; set; }
        public string LessonGroupName { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Lesson> Lesson { get; set; }
    }
}
