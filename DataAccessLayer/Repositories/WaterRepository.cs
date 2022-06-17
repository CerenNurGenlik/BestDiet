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
        public List<Water> GetWatersByDate(DateTime dateTime)
        {
            return MainRepository.db.Waters.Where(w => w.WaterDate == dateTime).ToList();
        }

        public List<Water> GetWatersByQuantity(int quantity)
        {
            return MainRepository.db.Waters.Where(w => w.Quantity == quantity).ToList();
        }
    }
}
