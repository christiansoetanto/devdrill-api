using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Lesson

    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string VideoUrl { get; set; }
        public string VideoType { get; set; }
        public string ThumbnailUrl { get; set; }
        public int LessonGroupId { get; set; }
        public LessonGroup LessonGroup { get; set; }
        public List<MappingUserLessonDone> MappingUserLessonDones { get; set; }
    }

    public class LessonModelBuilder : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> entity)
        {
            entity.HasKey(e => e.LessonId);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.HasData(

                // HTML 
                new
                {
                    LessonId = 1,
                    Name = "HTML Elements",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Elements",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 1
                },
                new
                {
                    LessonId = 2,
                    Name = "HTML Headings",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Headings",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 1
                },

                new
                {
                    LessonId = 3,
                    Name = "Membuat table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 2
                },
                new
                {
                    LessonId = 4,
                    Name = "Pelajaran lebih lanjut mengenai table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 2
                },

                 new
                 {
                     LessonId = 5,
                     Name = "HTML Elements",
                     Detail = "Pada lesson kali ini, akan diajarkan HTML Elements",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 3
                 },
                new
                {
                    LessonId = 6,
                    Name = "HTML Headings",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Headings",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 3
                },

                new
                {
                    LessonId = 7,
                    Name = "Membuat table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 4
                },
                new
                {
                    LessonId = 8,
                    Name = "Pelajaran lebih lanjut mengenai table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 4
                },

                  new
                  {
                      LessonId = 9,
                      Name = "HTML Elements",
                      Detail = "Pada lesson kali ini, akan diajarkan HTML Elements",
                      StartDateTime = DateTime.Now,
                      EndDateTime = DateTime.Now,
                      VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                      ThumbnailUrl = "lesson1.jpg",
                      LessonGroupId = 5
                  },
                new
                {
                    LessonId = 10,
                    Name = "HTML Headings",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Headings",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 5
                },

                new
                {
                    LessonId = 11,
                    Name = "Membuat table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 6
                },
                new
                {
                    LessonId = 12,
                    Name = "Pelajaran lebih lanjut mengenai table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 6
                },

                new
                {
                    LessonId = 13,
                    Name = "HTML Elements",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Elements",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
				    VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 7
                },
                new
                {
                    LessonId = 14,
                    Name = "HTML Headings",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Headings",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 7
                },

                new
                {
                    LessonId = 15,
                    Name = "Membuat table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 8
                },
                new
                {
                    LessonId = 16,
                    Name = "Pelajaran lebih lanjut mengenai table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 8
                },

                new
                {
                    LessonId = 17,
                    Name = "HTML Elements",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Elements",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
				    VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 9
                },
                new
                {
                    LessonId = 18,
                    Name = "HTML Headings",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML Headings",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 9
                },

                new
                {
                    LessonId = 19,
                    Name = "Membuat table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 10
                },
                new
                {
                    LessonId = 20,
                    Name = "Pelajaran lebih lanjut mengenai table pada HTML",
                    Detail = "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 10
                },

                // CSS
                // 11.
                new
                {
                    LessonId = 21,
                    Name = "CSS Syntax",
                    Detail = "Pada lesson kali ini, akan diajarkan syntax pada CSS",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 11
                },
                 // 12.
                 new
                 {
                     LessonId = 22,
                     Name = "Struktur dari CSS Box Model",
                     Detail = "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 12
                 },
                 new
                 {
                     LessonId = 23,
                     Name = "Kustomisasi Box Model CSS",
                     Detail = "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 12
                 },
                 // 13.
                 new
                 {
                     LessonId = 24,
                     Name = "CSS Syntax",
                     Detail = "Pada lesson kali ini, akan diajarkan syntax pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 13
                 },
                 // 14.
                 new
                 {
                     LessonId = 25,
                     Name = "Struktur dari CSS Box Model",
                     Detail = "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 14
                 },
                 new
                 {
                     LessonId = 26,
                     Name = "Kustomisasi Box Model CSS",
                     Detail = "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 14
                 },
                // 15.
                new
                {
                    LessonId = 27,
                    Name = "CSS Syntax",
                    Detail = "Pada lesson kali ini, akan diajarkan syntax pada CSS",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 15
                },
                 // 16.
                 new
                 {
                     LessonId = 28,
                     Name = "Struktur dari CSS Box Model",
                     Detail = "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 16
                 },
                 new
                 {
                     LessonId = 29,
                     Name = "Kustomisasi Box Model CSS",
                     Detail = "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 16
                 },
                 // 17.
                 new
                 {
                     LessonId = 30,
                     Name = "CSS Syntax",
                     Detail = "Pada lesson kali ini, akan diajarkan syntax pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 17
                 },
                 // 18.
                 new
                 {
                     LessonId = 31,
                     Name = "Struktur dari CSS Box Model",
                     Detail = "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 18
                 },
                 new
                 {
                     LessonId = 32,
                     Name = "Kustomisasi Box Model CSS",
                     Detail = "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 18
                 },
                 // 19.

                 new
                 {
                     LessonId = 33,
                     Name = "CSS Syntax",
                     Detail = "Pada lesson kali ini, akan diajarkan syntax pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 19
                 },
                 // 20.
                 new
                 {
                     LessonId = 34,
                     Name = "Struktur dari CSS Box Model",
                     Detail = "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 20
                 },
                 new
                 {
                     LessonId = 35,
                     Name = "Kustomisasi Box Model CSS",
                     Detail = "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 20
                 },

                 // JS
                 new
                 {
                     LessonId = 36,
                     Name = "Apa itu bahasa pemrograman Javascript?",
                     Detail = "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 21
                 },
                new
                {
                    LessonId = 37,
                    Name = "Apa saja yang bisa dilakukan Javascript",
                    Detail = "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 21
                },

                new
                {
                    LessonId = 38,
                    Name = "Mendefinisikan Variabel pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 22
                },
                new
                {
                    LessonId = 39,
                    Name = "Tipe Data pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 22
                },

                new
                {
                    LessonId = 40,
                    Name = "Apa itu bahasa pemrograman Javascript?",
                    Detail = "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 23
                },
                new
                {
                    LessonId = 41,
                    Name = "Apa saja yang bisa dilakukan Javascript",
                    Detail = "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 23
                },

                new
                {
                    LessonId = 42,
                    Name = "Mendefinisikan Variabel pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 24
                },
                new
                {
                    LessonId = 43,
                    Name = "Tipe Data pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 24
                },

                new
                {
                    LessonId = 44,
                    Name = "Apa itu bahasa pemrograman Javascript?",
                    Detail = "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 25
                },
                new
                {
                    LessonId = 45,
                    Name = "Apa saja yang bisa dilakukan Javascript",
                    Detail = "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 25
                },

                new
                {
                    LessonId = 46,
                    Name = "Mendefinisikan Variabel pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 26
                },
                new
                {
                    LessonId = 47,
                    Name = "Tipe Data pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 26
                },

                 new
                 {
                     LessonId = 48,
                     Name = "Apa itu bahasa pemrograman Javascript?",
                     Detail = "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 27
                 },
                new
                {
                    LessonId = 49,
                    Name = "Apa saja yang bisa dilakukan Javascript",
                    Detail = "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 27
                },

                new
                {
                    LessonId = 50,
                    Name = "Mendefinisikan Variabel pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 28
                },
                new
                {
                    LessonId = 51,
                    Name = "Tipe Data pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 28
                },

                 new
                 {
                     LessonId = 52,
                     Name = "Apa itu bahasa pemrograman Javascript?",
                     Detail = "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript",
                     StartDateTime = DateTime.Now,
                     EndDateTime = DateTime.Now,
                     VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                     ThumbnailUrl = "lesson1.jpg",
                     LessonGroupId = 29
                 },
                new
                {
                    LessonId = 53,
                    Name = "Apa saja yang bisa dilakukan Javascript",
                    Detail = "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 29
                },

                new
                {
                    LessonId = 54,
                    Name = "Mendefinisikan Variabel pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 30
                },
                new
                {
                    LessonId = 55,
                    Name = "Tipe Data pada Javascript",
                    Detail = "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    VideoUrl = "sample.mp4",
					VideoType = "video/mp4",
                    ThumbnailUrl = "lesson1.jpg",
                    LessonGroupId = 30
                }

            );
        }
    }
}