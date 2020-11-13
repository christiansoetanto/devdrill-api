namespace DevDrillWebAPI.Models
{
    public class TrackModel
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public string TrackDescription { get; set; }
        public int? TrackGroupId { get; set; }
    }
}