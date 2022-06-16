using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository
    {
        BestDietDbContext db;
        public UserRepository()
        {
            db = new BestDietDbContext();
        }
        public List<User> GetUsersByUserType(UserType userType)
        {
            return db.Users.Where(u=> u.UserType == userType).ToList();
        }
        public List<User> GetUsersByIsActive(bool isActive)
        {
            return db.Users.Where(u=>u.IsActive == isActive).ToList();
        }
    }
}
