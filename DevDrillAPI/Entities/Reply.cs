using System;
using System.Collections.Generic;
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
                GenerateSeeds()
            );
        }

        private Reply[] GenerateSeeds()
        {
            List<Reply> list = new List<Reply>();
            string[] reply = {
                "Jadi yang harus di install duluan itu ada .......",
                "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya",
                "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini...."
            };

            int threadId = 0;
            int replyId = 0;
            int[] userId = { 3, 6, 1 };

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    threadId++;
                    replyId++;
                    list.Add(
                        new Reply
                        {
                            ReplyId = replyId,
                            InsertDate = DateTime.Now,
                            Detail = reply[j],
                            ThreadId = threadId,
                            UserId = userId[j],
                            Upvote = new Random().Next(1, 10)
                        }
                    );
                }
            }


            return list.ToArray();
        }


    }
}