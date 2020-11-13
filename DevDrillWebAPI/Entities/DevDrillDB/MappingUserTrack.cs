using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class MappingUserTrack
    {
        public int UserId { get; set; }
        public int TrackId { get; set; }

        public virtual Track Track { get; set; }
        public virtual User User { get; set; }
    }
}
