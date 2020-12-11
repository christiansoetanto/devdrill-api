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
        public string Detail { get; set; }
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
                GenerateSeeds()
            );
        }

        private object[] GenerateSeeds()
        {
            List<object> list = new List<object>();
            string[] problem = { "Bagaimana konfigurasi setup?", "Error 500", "HTTP:404 Not Found" };
            string[] detail = {
                "Apa saja hal penting yang harus di install?",
                "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?",
                "Udah cek code nya tapi tetep muncul Not Found"
            };
            int[] userId = { 1, 3, 6 };
            int TID = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TID++;
                    list.Add(
                        new
                        {
                            ThreadId = TID,
                            InsertDate = DateTime.Now,
                            Topic = problem[j],
                            UserId = userId[j],
                            Upvote = new Random().Next(1, 500),
                            DiscussionId = i,
                            Detail = detail[j]
                        }
                    );
                }
            }
            return list.ToArray();
        }
    }
}