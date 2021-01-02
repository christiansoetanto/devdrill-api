using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class MappingUserLessonDone

    {
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime LastActive { get; set; }
    }

    public class MappingUserCourseModelBuilder : IEntityTypeConfiguration<MappingUserLessonDone>
    {
        public void Configure(EntityTypeBuilder<MappingUserLessonDone> entity)
        {
            entity.HasKey(e => new{e.LessonId, e.UserId});
            entity.HasOne(e => e.Lesson).WithMany(e => e.MappingUserLessonDones).HasForeignKey(e => e.LessonId);
            entity.HasOne(e => e.User).WithMany(e => e.MappingUserLessonDones).HasForeignKey(e => e.UserId);

            entity.HasData(
                new
                {
                    LessonId = 1,
                    UserId = 1,
                    LastActive = DateTime.Now
                }
                );
        }
    }
}