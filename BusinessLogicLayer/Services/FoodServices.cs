using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class FoodServices
    {
        FoodRepository foodRepository;
        MealRepository mealRepository;
        public FoodServices()
        {
            foodRepository = new FoodRepository();
            mealRepository = new MealRepository();
        }

        public List<Food> GetFoods()
        {
            List<Food> foodList = new List<Food>();
            foodList = foodRepository.GetFoods();
            return foodList;
        }
        //ÇALIŞMAYABİLİR....!!!
        //public List<Food> GetFoodsByMealCategoryIdAndUserId(string userID,int mealCategoryID,DateTime dateTime)
        //{
        //    Meal meal = mealRepository.GetMealByUserIDandMealCategoryID(userID, mealCategoryID, dateTime);
            
        //}

        
          
        


    }
}
