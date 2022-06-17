﻿using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealDetailRepository
    {
        BestDietDbContext db;
        public MealDetailRepository()
        {
            db = new BestDietDbContext();
        }
        public List<MealDetail> GetMealDeteailByMealId(int mealID)
        {
            return db.MealDetails.Where(a => a.MealID == mealID).ToList();
        }
        public bool Delete(int mealDetailId)
        {
            MealDetail mealDetail= db.MealDetails.Where(a => a.MealDetailID == mealDetailId).FirstOrDefault();
            db.MealDetails.Remove(mealDetail);
            return db.SaveChanges() > 0;
        }   
        public bool Insert(MealDetail mealDetail)
        {
            db.MealDetails.Add(mealDetail);
            return db.SaveChanges() > 0;
        }
        public bool Update(MealDetail mealDetail)
        {
            MealDetail updatedMealDetail = db.MealDetails.Find(mealDetail.MealDetailID);
            updatedMealDetail.Quantity = mealDetail.Quantity;
            updatedMealDetail.Meal.MealTime = mealDetail.Meal.MealTime;
            updatedMealDetail.Portion = mealDetail.Portion;
            return db.SaveChanges() > 0;
        }
    }
}
