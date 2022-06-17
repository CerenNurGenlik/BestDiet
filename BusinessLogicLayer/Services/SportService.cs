using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class SportService
    {
        SportRepository sportRepository;
        public SportService()
        {
            sportRepository = new SportRepository();
        }

        public List<Sport> GetCaloriesByQuantity(int burningCalori)
        {
            List<Sport> caloriList = new List<Sport>();
            caloriList = sportRepository.GetCaloriesByQuantity(burningCalori);
            return caloriList;
        }

        public List<Sport> GetSports()
        {
            List<Sport> sportList = new List<Sport>();
            sportList = sportRepository.GetSports();
            return sportList;
        }

        public List<Sport> GetSportsAll()
        {
            List<Sport> sportListAll = new List<Sport>();
            sportListAll = sportRepository.GetSportsAll();
            return sportListAll;
        }
    }
}
