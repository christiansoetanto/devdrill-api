using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class TrackGroupDto

    {
        public int TrackGroupId { get; set; }
        public string TrackGroupName { get; set; }
        public List<TrackDto> Tracks { get; set; }
    }
}