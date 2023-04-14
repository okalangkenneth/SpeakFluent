using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeakFluent.Models;

namespace SpeakFluent.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<AIModel> AIModels { get; set; }
        public DbSet<ProgressTracker> ProgressTrackers { get; set; }
        public DbSet<Flashcard> Flashcards { get; set; }
        public DbSet<PracticeExercise> PracticeExercises { get; set; }
        public DbSet<UserInteraction> UserInteractions { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Discussion> Discussions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SubscriptionPlan>(entity =>
            {
                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.SubscriptionPlan)
                .WithMany(s => s.Users)
                .HasForeignKey(u => u.SubscriptionPlanId);

            // Custom configuration for Course
            modelBuilder.Entity<Course>()
                .HasIndex(c => c.Name)
                .IsUnique();

            // Foreign key configurations
            modelBuilder.Entity<UserProfile>()
                .HasOne(u => u.ApplicationUser)
                .WithOne(a => a.UserProfile)
                .HasForeignKey<UserProfile>(u => u.ApplicationUserId);

            modelBuilder.Entity<ProgressTracker>()
                .HasOne(p => p.ApplicationUser)
                .WithMany(a => a.ProgressTrackers)
                .HasForeignKey(p => p.ApplicationUserId);

            modelBuilder.Entity<ProgressTracker>()
                .HasOne(p => p.Course)
                .WithMany(c => c.ProgressTrackers)
                .HasForeignKey(p => p.CourseId);

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.ApplicationUser)
                .WithMany(a => a.Bookmarks)
                .HasForeignKey(b => b.ApplicationUserId);

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.Lesson)
                .WithMany(l => l.Bookmarks)
                .HasForeignKey(b => b.LessonId);

            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany(c => c.Lessons)
                .HasForeignKey(l => l.CourseId);

            modelBuilder.Entity<UserInteraction>()
                .HasOne(u => u.ApplicationUser)
                .WithMany(a => a.UserInteractions)
                .HasForeignKey(u => u.ApplicationUserId);

            modelBuilder.Entity<Flashcard>()
                .HasOne(f => f.ApplicationUser)
                .WithMany(a => a.Flashcards)
                .HasForeignKey(f => f.ApplicationUserId);

            modelBuilder.Entity<PracticeExercise>()
                .HasOne(p => p.Lesson)
                .WithMany(l => l.PracticeExercises)
                .HasForeignKey(p => p.LessonId);

            modelBuilder.Entity<Discussion>()
                .HasOne(d => d.ApplicationUser)
                .WithMany(a => a.Discussions)
                .HasForeignKey(d => d.ApplicationUserId);

            modelBuilder.Entity<Discussion>()
                .HasOne(d => d.Forum)
                .WithMany(f => f.Discussions)
                .HasForeignKey(d => d.ForumId);
        }

        public DbSet<SpeakFluent.Models.SubscriptionPlan> SubscriptionPlan { get; set; }
    }
}
