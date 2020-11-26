namespace DevDrillAPI.Dto
{
    public class MappingUserTrackDto

    {
        public int TrackId { get; set; }
        public int UserId { get; set; }
        public int Progress { get; set; }

        public UserDto User { get; set; }
        public TrackDto Track { get; set; }
    }


}