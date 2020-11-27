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
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.HasData(
                new
                {
                    CourseId = 1,
                    PhotoUrl = "typescript.png",
                    Name = "Introduction to TS",
                    Detail = "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapa",
                    InsertDate = new DateTime(2012,9,12),
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 2,
                    PhotoUrl = "csharp.png",
                    Name = "Asynchronus Programming in C#", 
                    Detail = "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET",
                    InsertDate = new DateTime(2014, 9, 2),
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 3,
                    PhotoUrl = "php.png",
                    Name = "Object-Oriented Programming with PHP",
                    Detail = "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel",
                    InsertDate = new DateTime(2014, 12, 2),
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 4,
                    PhotoUrl = "python.png",
                    Name = "Python Programming Language",
                    Detail = "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian.",
                    InsertDate = new DateTime(2019, 3, 19),
                    TrackId = 1,
                    InstructorId = 1
                }
            );
        }
    }
}