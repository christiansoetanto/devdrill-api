using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class LessonGroupDto

    {
        public int LessonGroupId { get; set; }
        public string LessonGroupName { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public List<LessonDto> Lessons { get; set; }
    }

  
}