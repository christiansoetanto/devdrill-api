using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class TrackGroup

    {
        public int TrackGroupId { get; set; }
        public string TrackGroupName { get; set; }
        public List<Track> Tracks { get; set; }
    }

    public class TrackGroupModelBuilder : IEntityTypeConfiguration<TrackGroup>
    {
        public void Configure(EntityTypeBuilder<TrackGroup> entity)
        {
            entity.HasKey(e => e.TrackGroupId);
            entity.Property(e => e.TrackGroupName).IsRequired();
            entity.HasData(new
            {
                TrackGroupId = 1,
                TrackGroupName = "Fundamental Tracks"
            });
        }
    }
}