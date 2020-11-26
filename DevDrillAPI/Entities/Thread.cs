using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Thread

    {
        public int ThreadId { get; set; }
        public DateTime InsertDate { get; set; }

        public string Topic { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Upvote { get; set; }
        public List<Reply> Replies { get; set; }
        public int DiscussionId { get; set; }
        public Discussion Discussion { get; set; }
    }

    public class ThreadModelBuilder : IEntityTypeConfiguration<Thread>
    {
        public void Configure(EntityTypeBuilder<Thread> entity)
        {
            entity.HasKey(e => e.ThreadId);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.Topic).IsRequired();

            entity.HasData(
                new
                {
                    ThreadId = 1,
                    InsertDate = DateTime.Now,
                    Topic = "How to make this into",
                    UserId = 1,
                    Upvote = new Random().Next(1, 500),
                    DiscussionId = 1
                },
                new
                {
                    ThreadId = 2,
                    InsertDate = DateTime.Now,
                    Topic = "Error 500",
                    UserId = 1,
                    Upvote = new Random().Next(1, 500),
                    DiscussionId = 1
                },
                new
                {
                    ThreadId = 3,
                    InsertDate = DateTime.Now,
                    Topic = "HTTP404 Not Found",
                    UserId = 2,
                    Upvote = new Random().Next(1, 500),
                    DiscussionId = 3
                }
            );
        }
    }
}