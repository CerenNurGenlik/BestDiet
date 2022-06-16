using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Strategy
{
    public class BestDietStrategy : CreateDatabaseIfNotExists<BestDietDbContext>
    {
        protected override void Seed(BestDietDbContext context)
        {
            User user = new User()
            {
                UserID = "Admin",
                FirstName = "Admin",
                LastName = "Admin",
                IsActive = true,
                UserType = UserType.Admin
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
