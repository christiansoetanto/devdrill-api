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
                GenerateSeeds()
            );
        }
        private object[] GenerateSeeds()
        {
            List<object> list = new List<object>();
            list.Add(new
            {
                DiscussionId = 1,
                Name = "General Advice",
                DiscussionGroupId = 1
            });
            list.Add(new
            {
                DiscussionId = 2,
                Name = "Other Frameworks",
                DiscussionGroupId = 1
            });
            string[] template = { "Installation", "Regarding Video", "Development Advice" };
            for(int i = 2, ctr = 3; i <= 9; i++)
            {
                foreach(string name in template)
                {
                    list.Add(new
                    {
                        DiscussionId = ctr++,
                        Name = name,
                        DiscussionGroupId = i
                    });
                }
            }
            return list.ToArray();
        }
    }
}