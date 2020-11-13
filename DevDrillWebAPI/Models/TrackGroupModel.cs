using System.Collections.Generic;

namespace DevDrillWebAPI.Models
{
    public class TrackGroupModel
    {
        public int TrackGroupId { get; set; }
        public string TrackGroupName { get; set; }
        public List<TrackModel> Tracks { get; set; }

    }
}