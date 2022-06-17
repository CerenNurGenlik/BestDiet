using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodRepository
    {
        BestDietDbContext db;
        public FoodRepository()
        {
            db = new BestDietDbContext();
        }
        public List<Food> GetFoods()
        {
            return db.Foods.Where(a => a.IsActive).ToList();
        }
        public List<Food> GetFoodsByCategory(int foodCategoryID)
        {
            return db.Foods.Where(a => a.FoodCategoryID == foodCategoryID && a.IsActive).ToList();
        }
        public Food GetByFoodID(int foodID)
        {
            return db.Foods.Find(foodID);
        }
        public bool Insert(Food food)
        {
            db.Foods.Add(food);
            return db.SaveChanges() > 0;
        }
        public bool Delete(Food food)
        {
            Food deletedFood = db.Foods.Find(food.FoodID);
            deletedFood.IsActive = false;
            return db.SaveChanges() > 0;
        } 
        public List<Food> GetFoodsByText(string text)
        {
            return db.Foods.Where(a => a.FoodName.Contains(text)).ToList();

        }
    }
}
