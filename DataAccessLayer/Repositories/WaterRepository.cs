using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class WaterRepository
    {
        BestDietDbContext db;

        public WaterRepository()
        {
            db = new BestDietDbContext();
        }

        public List<Water> GetWatersByDate(DateTime dateTime)
        {
            return db.Waters.Where(w => w.WaterDate == dateTime).ToList();
        }

        public List<Water> GetWatersByQuantity(int quantity)
        {
            return db.Waters.Where(w => w.Quantity == quantity).ToList();
        }
    }
}
