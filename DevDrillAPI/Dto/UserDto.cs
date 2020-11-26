using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsInstructor { get; set; }
        public InstructorDto Instructor { get; set; }
        public List<ThreadDto> Threads { get; set; }
        public List<ReplyDto> Replies { get; set; }
        public MappingUserCourseDto MappingUserCourse { get; set; }
        public MappingUserTrackDto MappingUserTrack { get; set; }
    }

  
}