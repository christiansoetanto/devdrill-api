using System;
using System.Collections.Generic;

namespace DevDrillWebAPI.Entities.DevDrillDB
{
    public partial class User
    {
        public User()
        {
            MappingUserCourse = new HashSet<MappingUserCourse>();
            MappingUserTrack = new HashSet<MappingUserTrack>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<MappingUserCourse> MappingUserCourse { get; set; }
        public virtual ICollection<MappingUserTrack> MappingUserTrack { get; set; }
    }
}
