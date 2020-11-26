using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Track

    {
        public int TrackId { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int TrackGroupId { get; set; }
        public TrackGroup TrackGroup { get; set; }
        public MappingUserTrack MappingUserTrack { get; set; }
    }

    public class TrackModelBuilder : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> entity)
        {
            entity.HasKey(e => e.TrackId);
            entity.HasData(new
            {
                TrackId = 1,
                PhotoUrl = "track1.jpg",
                Name = "HTML",
                Detail = "Pada track ini, anda akan fokus pada pemakaian HTML sebagai bahasa markup yang sering digunakan dalam pembuatan struktur tampilan web. Ketika l",
                TrackGroupId = 1
            });
        }
    }
}