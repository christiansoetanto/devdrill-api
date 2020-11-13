using System;
using DevDrillWebAPI.Entities.DevDrillDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DevDrillWebAPI
{
    public partial class DevDrillDbContext : DbContext
    {
        public DevDrillDbContext()
        {
        }

        public DevDrillDbContext(DbContextOptions<DevDrillDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<LessonGroup> LessonGroup { get; set; }
        public virtual DbSet<MappingUserCourse> MappingUserCourse { get; set; }
        public virtual DbSet<MappingUserTrack> MappingUserTrack { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<TrackGroup> TrackGroup { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http: //go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=DevDrillDB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseDescription).IsUnicode(false);

                entity.Property(e => e.CourseImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.InstructorId).HasColumnName("InstructorID");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__Course__Instruct__2E1BDC42");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.TrackId)
                    .HasConstraintName("FK__Course__TrackID__2D27B809");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.Property(e => e.InstructorId).HasColumnName("InstructorID");

                entity.Property(e => e.InstructorImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstructorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.Property(e => e.LessonId).HasColumnName("LessonID");

                entity.Property(e => e.LessonDescription).IsUnicode(false);

                entity.Property(e => e.LessonEndTime).HasColumnType("datetime");

                entity.Property(e => e.LessonGroupId).HasColumnName("LessonGroupID");

                entity.Property(e => e.LessonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LessonStartTime).HasColumnType("datetime");

                entity.HasOne(d => d.LessonGroup)
                    .WithMany(p => p.Lesson)
                    .HasForeignKey(d => d.LessonGroupId)
                    .HasConstraintName("FK__Lesson__LessonGr__33D4B598");
            });

            modelBuilder.Entity<LessonGroup>(entity =>
            {
                entity.Property(e => e.LessonGroupId).HasColumnName("LessonGroupID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.LessonGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.LessonGroup)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__LessonGro__Cours__30F848ED");
            });

            modelBuilder.Entity<MappingUserCourse>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.CourseId})
                    .HasName("PK__MappingU__7B1A1BB4362E2292");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.MappingUserCourse)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MappingUs__Cours__3B75D760");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MappingUserCourse)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MappingUs__UserI__3A81B327");
            });

            modelBuilder.Entity<MappingUserTrack>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.TrackId})
                    .HasName("PK__MappingU__002F8320BB555165");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.MappingUserTrack)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MappingUs__Track__37A5467C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MappingUserTrack)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MappingUs__UserI__36B12243");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.Property(e => e.TrackDescription).IsUnicode(false);

                entity.Property(e => e.TrackGroupId).HasColumnName("TrackGroupID");

                entity.Property(e => e.TrackName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TrackGroup)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.TrackGroupId)
                    .HasConstraintName("FK__Track__TrackGrou__286302EC");
            });

            modelBuilder.Entity<TrackGroup>(entity =>
            {
                entity.Property(e => e.TrackGroupId).HasColumnName("TrackGroupID");

                entity.Property(e => e.TrackGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("UQ__User__536C85E461C366FB")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}