using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealCategoryRepository
    {
        BestDietDbContext db;
        public MealCategoryRepository()
        {
            db= new BestDietDbContext();
        }

        public List<MealCategory> GetMealCategories()
        {
            return db.MealCategories.ToList();
        }
    }
}
