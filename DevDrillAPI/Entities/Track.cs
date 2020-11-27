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
            entity.HasData(
                new
                {
                    TrackId = 1,
                    PhotoUrl = "html.png",
                    Name = "HTML",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian HTML sebagai bahasa markup yang sering digunakan dalam pembuatan struktur tampilan web. Ketika l",
                    TrackGroupId = 1
                },
                new
                {
                    TrackId = 2,
                    PhotoUrl = "css.png",
                    Name = "CSS",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian CSS sebagai style yang sering digunakan untuk mempercantik tampilan web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 1
                },
                new
                {
                    TrackId = 3,
                    PhotoUrl = "javascript.png",
                    Name = "Javascript",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian JS sebagai bahasa program yang sering digunakan dalam pembuatan logic dari web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 1
                },
                new
                {
                    TrackId = 4,
                    PhotoUrl = "react.png",
                    Name = "React.js Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian React.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 2
                },
                new
                {
                    TrackId = 5,
                    PhotoUrl = "angular.png",
                    Name = "Angular Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Angular sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 2
                },
                new
                {
                    TrackId = 6,
                    PhotoUrl = "vuejs.png",
                    Name = "Vue.js Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Vue.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 2
                },
                new
                {
                    TrackId = 7,
                    PhotoUrl = "netcore.png",
                    Name = ".NET Core Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian .NET Core sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 3
                },
                new
                {
                    TrackId = 8,
                    PhotoUrl = "laravel.png",
                    Name = "Laravel Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Laravel sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 3
                },
                new
                {
                    TrackId = 9,
                    PhotoUrl = "django.png",
                    Name = "Django Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Django sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 3
                },
                new
                {
                    TrackId = 10,
                    PhotoUrl = "nodejs.png",
                    Name = "Node.js Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Node.js sebagai run-time environment yang sering digunakan dalam pembuatan web application. Disini kita akan menggunakan Express.js sebagai media frameworknya. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 3
                },
                new
                {
                    TrackId = 11,
                    PhotoUrl = "spring.png",
                    Name = "Spring Developer",
                    Detail = "Pada track ini, anda akan fokus pada pemakaian Spring sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.",
                    TrackGroupId = 3
                }
            );
        }
    }
}