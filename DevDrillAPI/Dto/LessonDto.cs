using System;

namespace DevDrillAPI.Dto
{
    public class LessonDto

    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string VideoUrl { get; set; }
        public string VideoType { get; set; }
        public string ThumbnailUrl { get; set; }
        public int LessonGroupId { get; set; }
        public LessonGroupDto LessonGroup { get; set; }
        public MappingUserLessonDoneDto MappingUserLessonDone { get; set; }
    }

   
}