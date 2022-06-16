using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SportRepository
    {
        BestDietDbContext db;

        public SportRepository()
        {
            db = new BestDietDbContext();
        }

        public List<Sport> GetCaloriesByQuantity(int burningCalori)
        {
            return db.Sports.Where(w => w.BurningCalori == burningCalori).ToList();
        }

        public List<Sport> GetSportsByIsActive(bool isActive)
        {
            return db.Sports.Where(u => u.IsActive == isActive).ToList();
        }
    }
}
