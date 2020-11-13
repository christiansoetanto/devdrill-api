using System;

namespace DevDrillWebAPI.Models
{
    public class LessonModel
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonDescription { get; set; }
        public DateTime? LessonStartTime { get; set; }
        public DateTime? LessonEndTime { get; set; }
        public int? CourseId { get; set; }
        public int? LessonGroupId { get; set; }
    }
}