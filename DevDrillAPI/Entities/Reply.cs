using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Reply

    {
        public int ReplyId { get; set; }
        public DateTime InsertDate { get; set; }
        public string Detail { get; set; }
        public int ThreadId { get; set; }
        public int Upvote { get; set; }
        public Thread Thread { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class ReplyModelBuilder : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> entity)
        {
            entity.HasKey(e => e.ReplyId);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");

            entity.HasData(
                new
                {
                    ReplyId = 1,
                    InsertDate = DateTime.Now,
                    Detail = "how to make this into this i dont know pleaseeeee help meeeee",
                    ThreadId = 1,
                    UserId = 1,
                    Upvote = new Random().Next(1,10)
                },
                new
                {
                    ReplyId = 2,
                    InsertDate = DateTime.Now,
                    Detail = "okay so this is how you do this....",
                    ThreadId = 1,
                    UserId = 2,
                    Upvote = new Random().Next(1, 10)

                },
                new
                {
                    ReplyId = 3,
                    InsertDate = DateTime.Now,
                    Detail = "hey guys i got error 500 cna somebody help me?",
                    ThreadId = 2,
                    UserId = 1,
                    Upvote = new Random().Next(1, 10)

                },
                new
                {
                    ReplyId = 4,
                    InsertDate = DateTime.Now,
                    Detail = "no we cant",
                    ThreadId = 2,
                    UserId = 2,
                    Upvote = new Random().Next(1, 10)

                },
                new
                {
                    ReplyId = 5,
                    InsertDate = DateTime.Now,
                    Detail = "You want to find this topic but HTTP404 Not Found...",
                    ThreadId = 3,
                    UserId = 2,
                    Upvote = new Random().Next(1, 10)

                }
            );
        }
    }
}