using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsInstructor { get; set; }
        public Instructor Instructor { get; set; }
        public List<Thread> Threads { get; set; }
        public List<Reply> Replies { get; set; }
        public MappingUserCourse MappingUserCourse { get; set; }
        public MappingUserTrack MappingUserTrack { get; set; }
    }

    public class UserModelBuilder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhotoUrl)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IsInstructor)
                .IsRequired()
                .HasConversion<byte>();

            entity.HasData(
                new
                {
                    UserId = 1, Username = "user1", Password = "user1", Name = "user biasa", PhotoUrl = "photo1.jpg",
                    IsInstructor = false
                },
                new
                {
                    UserId = 2, Username = "user2", Password = "user2", Name = "instructor", PhotoUrl = "photo2.jpg",
                    IsInstructor = true
                }
                
            );
        }
    }
}