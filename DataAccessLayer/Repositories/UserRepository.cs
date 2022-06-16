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
        public User CheckLogin(string userName,string password)
        {
            User user = db.Users.Find(userName);
            if(user !=null && user.Password == password)
            {
                return user;
            }
            return null;
        }
        public User GetUserByUserName(string userName)
        {
            return db.Users.Find(userName);
        }
        public bool InsertUser(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }
    }
}
