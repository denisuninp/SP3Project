using Microsoft.EntityFrameworkCore;
using SP3Project.Domain.Models;

namespace SP3Project.Persistance.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryID = 1,
                    Name = "Cars",
                    Description = "Personal"
                },
                new Category()
                {
                    CategoryID = 2,
                    Name = "Trucks",
                    Description = "Business"
                }
            );
        }
    }
}
