using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository=new MealRepository();
        }
        public Meal GetMealByUserIDandMealCategoryID(string userID, int mealCategoryID, DateTime dateTime)
        {
            Meal meal = mealRepository.GetMealByUserIDandMealCategoryID(userID, mealCategoryID, dateTime);
            return meal;
        }
        public Meal GetMealByUserIDandMealCategoryName(string userID, string mealCategoryName, DateTime dateTime)
        {
            Meal meal = mealRepository.GetMealByUserIDandMealCategoryName(userID, mealCategoryName, dateTime);
            return meal;
        }
    }
}
