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

        public List<Sport> GetSports()
        {
            return db.Sports.Where(u => u.IsActive == true).ToList();
        }

        public List<Sport> GetSportsAll()
        {
            return db.Sports.ToList();
        }
    }
}
