using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class MappingUserTrack

    {
        public int TrackId { get; set; }
        public int UserId { get; set; }
        public int Progress { get; set; }

        public User User { get; set; }
        public Track Track { get; set; }
    }

    public class MappingUserTrackModelBuilder : IEntityTypeConfiguration<MappingUserTrack>
    {
        public void Configure(EntityTypeBuilder<MappingUserTrack> entity)
        {
            entity.HasKey(e => new {e.TrackId, e.UserId});
            entity.HasData(
                new
                {
                    TrackId = 1,
                    UserId = 1,
                    Progress = new Random().Next(1, 10)
                }
            );
        }
    }
}