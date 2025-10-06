using TestingPlatform1.Models; 
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace TestingPlatform1
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Student> Students => Set<Student>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, 
                    Login = "petr111", 
                    Email = "petr11@gmail.com", 
                    FirstName = "fear",
                    MiddleName = "grat",
                    LastName = "resh", 
                    Phone = "79352235412",
                    VkProfileLink = "http://vk.com/petfdgr11221", 
                    CreatedAt = new DateTimeOffset(2025, 10, 6, 3, 51, 51, offset: TimeSpan.FromHours(3))},
                new Student
                {
                    Id = 2,
                    Login = "katya111",
                    Email = "katya11@gmail.com",
                    FirstName = "fewar",
                    MiddleName = "grherat",
                    LastName = "reslolh",
                    Phone = "79357775612",
                    VkProfileLink = "http://vk.com/kathsdha2134",
                    CreatedAt = new DateTimeOffset(2025, 10, 6, 5, 34, 21, offset: TimeSpan.FromHours(3))
                }
                 );
        }
    }
}
