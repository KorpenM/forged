using Forged.Models;
using Microsoft.EntityFrameworkCore;

namespace Forged.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<WorkoutSession> WorkoutSessions { get; set; }
        public DbSet<ActivityDetail> ActivityDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutSession>()
                .HasOne(w => w.User)
                .WithMany(u => u.WorkoutSessions)
                .HasForeignKey(w => w.UserId);

            modelBuilder.Entity<ActivityDetail>()
                .HasOne(a => a.WorkoutSession)
                .WithMany(w => w.ActivityDetails)
                .HasForeignKey(a => a.WorkoutSessionId);
        }
    }
}