using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class WaterService
    {
        WaterRepository waterRepository;
        public WaterService()
        {
            waterRepository = new WaterRepository();
        }

        public List<Water> GetWatersByDate(DateTime dateTime)
        {
            List<Water> waterList = new List<Water>();
            waterList = waterRepository.GetWatersByDate(dateTime);
            return waterList;
        }

        public List<Water> GetWatersByQuantity(int quantity)
        {
            List<Water> water = new List<Water>();
            water = waterRepository.GetWatersByQuantity(quantity);
            return water;
        }

        void CheckWaterID(int waterID)
        {
            if (waterID <= 0) throw new Exception("Su eklenmemiştir.");
        }
    }
}
