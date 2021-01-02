namespace DevDrillAPI.Dto
{
    public class TrackDto

    {
        public int TrackId { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int TrackGroupId { get; set; }
        public TrackGroupDto TrackGroup { get; set; }
        public double? Progress { get; set; }
    }

    
}