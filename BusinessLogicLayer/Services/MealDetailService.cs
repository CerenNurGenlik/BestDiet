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

        public List<MealDetail> GetMealDetailsByMealID(int mealID)
        {
            return mealDetailRepository.GetMealDeteailsByMealId(mealID);
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
            //CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Insert(mealDetail);
        }
        public bool Update(MealDetail mealDetail)
        {
            CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Update(mealDetail);
        }
        public MealDetail GetMealDetailById(int mealDetailId)
        {
            CheckMealDetailId(mealDetailId);
            return mealDetailRepository.GetMealDetailById(mealDetailId);
        }
    }
}
