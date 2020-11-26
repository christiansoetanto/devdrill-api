using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class DiscussionGroup

    {
        public int DiscussionGroupId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public List<Discussion> Discussions { get; set; }
    }

    public class DiscussionGroupModelBuilder : IEntityTypeConfiguration<DiscussionGroup>
    {
        public void Configure(EntityTypeBuilder<DiscussionGroup> entity)
        {
            entity.HasKey(e => e.DiscussionGroupId);
            entity.HasData(
                new
                {
                    DiscussionGroupId = 1,
                    Name = "Public discussion",
                    PhotoUrl = "dg1.jpg"
                }, new
                {
                    DiscussionGroupId = 2,
                    Name = "Angular discussion",
                    PhotoUrl = "dg1.jpg"
                }
            );
        }
    }
}