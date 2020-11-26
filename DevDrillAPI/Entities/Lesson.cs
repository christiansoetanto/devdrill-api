using System;
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
        public string ThumbnailUrl { get; set; }
        public int LessonGroupId { get; set; }
        public LessonGroup LessonGroup { get; set; }
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
                new
                {
                    LessonId = 1, Name = "Hello world in ts", Detail = "ini adalah lesson hello world in ts", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 1
                },
                new
                {
                    LessonId = 2, Name = "selection n loop control", Detail = "ini adlaah selection n loop control", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 1
                },
                new
                {
                    LessonId = 3, Name = "creating a basic calculator", Detail = "ini adlah creating a basic calculator", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 1
                },
                new
                {
                    LessonId = 4, Name = "Defining a function", Detail = "ini adalah definig a cufntioni", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 2
                },
                new
                {
                    LessonId = 5, Name = "class n object ", Detail = "this is class n object ", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 2
                },
                new
                {
                    LessonId = 6, Name = "making a basci tdiyr pogmra", Detail = "ini dalah detail darti making a basci tdiyr pogmra", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now,
                    VideoUrl = "video1", ThumbnailUrl = "lesson1.jpg", LessonGroupId = 2
                }
                
            );
        }
    }
}