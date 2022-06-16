using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodCategoryRepository
    {
        BestDietDbContext db;
        public FoodCategoryRepository()
        {
            db = new BestDietDbContext();
        }
        public List<FoodCategory> GetFoodCategories()
        {
            return db.FoodCategories.ToList();
        }
    }
}
