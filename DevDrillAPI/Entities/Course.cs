using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Course

    {
        public int CourseId { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime InsertDate { get; set; }
        public List<LessonGroup> LessonGroups { get; set; }
        public int TrackId { get; set; }
        public Track Track { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public MappingUserCourse MappingUserCourse { get; set; }
    }

    public class CourseModelBuilder : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasKey(e => e.CourseId);
            entity.Property(e => e.PhotoUrl).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Detail).HasMaxLength(4000);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.HasData(
                new{
                    CourseId = 1,
                    PhotoUrl = "course1.jpg",
                    Name = "Introduction to TS",
                    Detail = "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapa",
                    InsertDate = DateTime.Now,
                    TrackId = 1,
                    InstructorId = 1
                }    
            );

        }
    }
}