using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class MappingUserCourse

    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public int Progress { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }
    }

    public class MappingUserCourseModelBuilder : IEntityTypeConfiguration<MappingUserCourse>
    {
        public void Configure(EntityTypeBuilder<MappingUserCourse> entity)
        {
            entity.HasKey(e => new{e.CourseId, e.UserId});
            entity.HasData(
                new
                {
                    CourseId = 1,
                    UserId = 1,
                    Progress = new Random().Next(1,10)
                }
                );
        }
    }
}