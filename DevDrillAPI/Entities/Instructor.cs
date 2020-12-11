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

            entity.HasData(
                new { UserId = 2, InstructorId = 1, Title = "CEO and Boss", CompanyName = "Perusahaan Saya" },
                new { UserId = 4, InstructorId = 2, Title = "Instructor X", CompanyName = "X" },
                new { UserId = 5, InstructorId = 3, Title = "Instructor Y", CompanyName = "Y" }
            );
        }
    }
}