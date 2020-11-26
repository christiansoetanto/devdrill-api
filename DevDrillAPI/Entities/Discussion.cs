using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Discussion

    {
        public int DiscussionId { get; set; }
        public string Name { get; set; }
        public List<Thread> Threads { get; set; }
        public int DiscussionGroupId { get; set; }
        public DiscussionGroup DiscussionGroup { get; set; }
    }

    public class DiscussionModelBuilder : IEntityTypeConfiguration<Discussion>
    {
        public void Configure(EntityTypeBuilder<Discussion> entity)
        {
            entity.HasKey(e => e.DiscussionId);
            entity.HasData(
                new
                {
                    DiscussionId = 1,
                    Name = "General Advice",
                    DiscussionGroupId = 1
                },
                new
                {
                    DiscussionId = 2,
                    Name = "Other Frameworks",
                    DiscussionGroupId = 1
                },
                new
                {
                    DiscussionId = 3,
                    Name = "Installation",
                    DiscussionGroupId = 2
                },
                new
                {
                    DiscussionId = 4,
                    Name = "Regarding Video",
                    DiscussionGroupId = 2
                }
            );
        }
    }
}