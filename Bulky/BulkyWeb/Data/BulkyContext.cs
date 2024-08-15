using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class BulkyContext:DbContext
    {
        public BulkyContext(DbContextOptions<BulkyContext>options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Action",
                    DisplayOrder = 1,

                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Terror",
                    DisplayOrder = 2,

                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Kids",
                    DisplayOrder = 3,

                }

                );

        }
    }
}
