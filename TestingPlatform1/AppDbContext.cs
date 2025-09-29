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
                    VkProfileLink = 'http://vk.com/petr11221', 
                    CreatedAt = DateTimeOffset.Now },
                new Student
                {
                    Id = 2,
                    Login = "katya111",
                    Email = "katya11@gmail.com",
                    FirstName = "fewar",
                    MiddleName = "grherat",
                    LastName = "reslolh",
                    Phone = "79357775612",
                    VkProfileLink = 'http://vk.com/katya2134',
                    CreatedAt = DateTimeOffset.Now
                }
                 );
        }
    }
}
