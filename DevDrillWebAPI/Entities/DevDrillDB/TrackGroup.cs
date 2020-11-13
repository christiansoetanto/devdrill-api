using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class TrackGroup
    {
        public TrackGroup()
        {
            Track = new HashSet<Track>();
        }

        public int TrackGroupId { get; set; }
        public string TrackGroupName { get; set; }

        public virtual ICollection<Track> Track { get; set; }
    }
}
