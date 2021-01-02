using System;
using System.Collections.Generic;
using DevDrillAPI.Entities;

namespace DevDrillAPI.Dto
{
    public class CourseDto

    {
        public int CourseId { get; set; }
        public string PhotoUrl { get; set; }
        public string CoverUrl { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime InsertDate { get; set; }
        public List<LessonGroupDto> LessonGroups { get; set; }
        public int TrackId { get; set; }
        public TrackDto Track { get; set; }
        public int InstructorId { get; set; }
        public UserDto User { get; set; }
        public double? Progress { get; set; }
    }

   
}


