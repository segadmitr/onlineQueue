using Microsoft.EntityFrameworkCore;
using QueueApp.Core.Domain;

namespace QueueApp.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Queue> Queues { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Queue>().HasOne(q => q.Room).WithMany(r => r.Queues).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
