using DataAccessLayer.EnitityConfigurations;
using DataAccessLayer.Strategy;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BestDietDbContext : DbContext
    {
        public BestDietDbContext() : base(@"Data Source=DESKTOP-46Q3ART\MSSQLKD10;Initial Catalog=030_BestDietDB;User=sa;Password=123456")
        {
            Database.SetInitializer(new BestDietStrategy());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Water> Waters { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<FoodCategory>  FoodCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new MealCategoryConfiguration());
        }
    }
}
