using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonDescription { get; set; }
        public DateTime? LessonStartTime { get; set; }
        public DateTime? LessonEndTime { get; set; }
        public int? LessonGroupId { get; set; }

        public virtual LessonGroup LessonGroup { get; set; }
    }
}
