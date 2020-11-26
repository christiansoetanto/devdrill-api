using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
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
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
            entity.Property(e => e.IsInstructor)
                .IsRequired()
                .HasConversion<byte>();

            entity.HasData(
                new
                {
                    UserId = 1, Password = "user1", Name = "user biasa", PhotoUrl = "photo1.jpg",
                    IsInstructor = false, Email = "user1@email.com", PhoneNumber = "0812121212112"
                },
                new
                {
                    UserId = 2,  Password = "user2", Name = "instructor", PhotoUrl = "photo2.jpg",
                    IsInstructor = true, Email = "user2@email.com", PhoneNumber = "08777777"
                }
            );
        }
    }
}