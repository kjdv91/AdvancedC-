using MenuApp.Models;
using Microsoft.EntityFrameworkCore;
using MenuApp.Models;

namespace MenuApp.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options): base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(
                di => new
                {
                    di.DishId,
                    di.IngredientId
                });
            // Data fire
            modelBuilder.Entity<Dish>().HasData(
                    new Dish { Id = 1, Name = "Pizza", ImageURL = "https://st2.depositphotos.com/1692343/5636/i/450/depositphotos_56360353-stock-photo-hot-homemade-pepperoni-pizza.jpg" },
                    new Dish { Id = 2, Name = "Hamburguer", ImageURL = "https://www.recetasnestle.com.ec/sites/default/files/srh_recipes/4e4293857c03d819e4ae51de1e86d66a.jpg" }
                    );
            modelBuilder.Entity<Ingredient>().HasData(
                    new Ingredient { Id=1, Name="Tomato"},
                    new Ingredient { Id = 2, Name = "Meat" },
                    new Ingredient { Id = 3, Name = "Cheese" },
                    new Ingredient { Id = 4, Name = "Lettuce" }
                );

            modelBuilder.Entity<DishIngredient>().HasData(
                    new DishIngredient { DishId = 1, IngredientId=1},
                    new DishIngredient { DishId = 1, IngredientId = 3 },
                    new DishIngredient { DishId = 2, IngredientId = 3 },
                    new DishIngredient { DishId = 2, IngredientId = 4 }
                );

            modelBuilder.Entity<DishIngredient>().HasOne(
                d => d.Dish).WithMany(di => di.DishIngredients)
                .HasForeignKey(d => d.DishId);

            modelBuilder.Entity<DishIngredient>().HasOne(
                i => i.Ingredient).WithMany(di => di.DishIngredients)
                .HasForeignKey(i => i.IngredientId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }

}
