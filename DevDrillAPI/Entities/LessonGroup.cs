using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class LessonGroup

    {
        public int LessonGroupId { get; set; }
        public string LessonGroupName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Lesson> Lessons { get; set; }
        
    }

    public class LessonGroupModelBuilder : IEntityTypeConfiguration<LessonGroup>
    {
        public void Configure(EntityTypeBuilder<LessonGroup> entity)
        {
            entity.HasKey(e => e.LessonGroupId);
            entity.Property(e => e.LessonGroupName).IsRequired();
            entity.HasData(
                new
                {
                    LessonGroupId = 1,
                    LessonGroupName = "Basic Operation n Meth",
                    CourseId = 1
                },
                new
                {
                    LessonGroupId = 2,
                    LessonGroupName = "FUnction n class",
                    CourseId = 1
                });
        }
    }
}