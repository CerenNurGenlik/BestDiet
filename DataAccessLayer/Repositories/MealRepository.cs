using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealRepository
    {
        BestDietDbContext db;
        public MealRepository()
        {
            db = new BestDietDbContext();
        }
        public List<Meal> GetMealsByDate(DateTime dateTime)
        {
            return db.Meals.Where(m=> m.MealTime == dateTime).ToList();
        }

        public List<Meal> GetMealsBetweenDates(DateTime startDate, DateTime endDate)
        {
            return db.Meals.Where(m => m.MealTime >= startDate && m.MealTime <= endDate).ToList();
        }
        public Meal GetMealByUserIDandMealCategoryID(string userID, int mealCategoryID, DateTime dateTime)
        {
            return db.Meals.Where(a => a.UserID == userID && a.MealCategoryID == mealCategoryID && a.MealTime == dateTime).FirstOrDefault();
        }
    }
}
