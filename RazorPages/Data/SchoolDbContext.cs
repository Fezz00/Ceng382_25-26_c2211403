using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var classData = new List<Class>();
            for (int i = 1; i <= 105; i++)
            {
                classData.Add(new Class
                {
                    Id = i,
                    ClassName = "Class " + i,
                    StudentCount = i * 2,
                    Description = "Class " + i + " Description",
                    isActive = true
                });
            }

            modelBuilder.Entity<Class>().HasData(classData);
        }

    }
}
