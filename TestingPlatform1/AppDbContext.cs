using TestingPlatform1.Models; 
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace TestingPlatform1
{
    public class AppDbContext : DbContext 
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Group> Groups => Set<Group>();
        public DbSet<Direction> Directions => Set<Direction>();
        public DbSet<Сourse> Courses => Set<Сourse>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
