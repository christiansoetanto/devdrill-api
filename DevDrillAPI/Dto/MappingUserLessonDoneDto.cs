using System;

namespace DevDrillAPI.Dto
{
    public class MappingUserLessonDoneDto

    {
        public int LessonId { get; set; }
        public LessonDto Lesson { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public DateTime LastActive { get; set; }
    }

 
}