using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        
        public FoodService()
        {
            foodRepository = new FoodRepository();
            
        }

        public List<Food> GetFoods()
        {
            List<Food> foodList = new List<Food>();
            foodList = foodRepository.GetFoods();
            return foodList;
        }        
        public bool Insert(Food food)
        {
            CheckFood(food);
            return foodRepository.Insert(food);
        }
        void CheckFood(Food food)
        {
            if (string.IsNullOrWhiteSpace(food.FoodName) || (food.FoodCategoryID<0)) 
                throw new Exception("Tüm bilgileri eksiksiz giriniz..");
            else if (food.Calori < 0) 
                throw new Exception("Kalori sıfırdan küçük olamaz..");
        }
        public bool Delete(Food food)
        {
            CheckFoodId(food.FoodID);
            return foodRepository.Delete(food);            
        }
       
        void CheckFoodId(int foodID)
        {
            if (foodID <= 0) throw new Exception("Yiyecek bulunamadı.");
        }
        public Food GetByFoodID(int foodID)
        {
            CheckFoodId(foodID);
            return foodRepository.GetByFoodID(foodID);
        }
        public List<Food> GetFoodsByText(string text)
        {
            return foodRepository.GetFoodsByText(text);
        }
    }
}
