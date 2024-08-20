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
                    Name = "Action"
                   

                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Terror"
                  

                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Kids"
                   

                }

                );

        }
    }
}
