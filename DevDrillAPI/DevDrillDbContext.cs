using System.Reflection;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevDrillAPI
{
    public class DevDrillDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<DiscussionGroup> DiscussionGroups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonGroup> LessonGroups { get; set; }
        public DbSet<MappingUserLessonDone> MappingUserLessonDones { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<TrackGroup> TrackGroups { get; set; }
        public DbSet<CobaCoba> Cobas { get; set; }

        public DevDrillDbContext()
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        public DevDrillDbContext(DbContextOptions<DevDrillDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ini buat nge-scan Assembly 
            // untuk apply konfigurasi IEntityTypeConfiguration<T>
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}