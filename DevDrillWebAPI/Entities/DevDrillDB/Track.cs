using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class Track
    {
        public Track()
        {
            Course = new HashSet<Course>();
            MappingUserTrack = new HashSet<MappingUserTrack>();
        }

        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public string TrackDescription { get; set; }
        public int? TrackGroupId { get; set; }

        public virtual TrackGroup TrackGroup { get; set; }
        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<MappingUserTrack> MappingUserTrack { get; set; }
    }
}
