using System.Collections.Generic;

namespace DevDrillWebAPI.Models
{
    public class LessonGroupModel
    {
        public int LessonGroupId { get; set; }
        public string LessonGroupName { get; set; }

        public List<LessonModel> Lessons { get; set; }
    }
}