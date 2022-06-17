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
        public Water GetWaterByDateAndUserName(DateTime dateTime, string userName)
        {
            return MainRepository.db.Waters.Where(w => w.WaterDate == dateTime && w.UserID == userName).FirstOrDefault();
        }

        public bool AddWater(Water water)
        {
            MainRepository.db.Waters.Add(water);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool UpdateWaterByWater(Water water)
        {
            Water updateWater = MainRepository.db.Waters.Find(water.WaterID);
            updateWater = water;
            return MainRepository.db.SaveChanges() > 0;
        }
        
    }
}
