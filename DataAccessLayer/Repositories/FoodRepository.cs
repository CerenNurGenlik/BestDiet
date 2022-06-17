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
        
        public List<Food> GetFoods()
        {
            return MainRepository.db.Foods.Where(a => !a.IsActive).ToList();
        }
        public List<Food> GetFoodsByCategory(int foodCategoryID)
        {
            return MainRepository.db.Foods.Where(a => a.FoodCategoryID == foodCategoryID && a.IsActive).ToList();
        }
        public Food GetByFoodID(int foodID)
        {
            return MainRepository.db.Foods.Find(foodID);
        }
        public bool Insert(Food food)
        {
            MainRepository.db.Foods.Add(food);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Delete(Food food)
        {
            Food deletedFood = MainRepository.db.Foods.Find(food.FoodID);
            deletedFood.IsActive = false;
            return MainRepository.db.SaveChanges() > 0;
        } 
        public List<Food> GetFoodsByText(string text)
        {
            return MainRepository.db.Foods.Where(a => a.FoodName.Contains(text)).ToList();

        }
    }
}
