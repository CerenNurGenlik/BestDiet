using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MealDetailService
    {
        MealRepository mealRepository;
        MealDetailRepository mealDetailRepository;

        public MealDetailService()
        {
            mealRepository = new MealRepository();
            mealDetailRepository = new MealDetailRepository();
        }

        public List<MealDetail> GetFoodsByMeal(string userID, int mealCategoryID, DateTime dateTime)
        {
            Meal meal = mealRepository.GetMealByUserIDandMealCategoryID(userID, mealCategoryID, dateTime);
            List<MealDetail> mealDetails = mealDetailRepository.GetMealDeteailByMealId(meal.MealID);
            return mealDetails;
        }
        public bool Delete(int mealDetailID)
        {
            CheckMealDetailId(mealDetailID);
            return mealDetailRepository.Delete(mealDetailID);

        }
        void CheckMealDetailId(int mealDetailId)
        {
            if (mealDetailId <= 0) throw new Exception("Öğüne ait yiyecekler bulunamadı.");
        }
        public bool Insert(MealDetail mealDetail)
        {
            CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Insert(mealDetail);
        }
        public bool Update(MealDetail mealDetail)
        {
            CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Update(mealDetail);
        }
        
    }
}
