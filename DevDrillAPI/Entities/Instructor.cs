using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Instructor
    {
        public int UserId { get; set; }
        public int InstructorId { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public User User { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class InstructorModelBuilder : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> entity)
        {
            entity.HasKey(e => e.InstructorId);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasData(
                new {UserId = 2, InstructorId = 1, Title = "CEO and Boss", CompanyName = "Perusahaan Saya"}
            );
        }
    }
}