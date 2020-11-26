namespace DevDrillAPI.Dto
{
    public class MappingUserCourseDto

    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public int Progress { get; set; }
        public UserDto User { get; set; }
        public CourseDto Course { get; set; }
    }

 
}