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

            List<Sport> sports = new List<Sport>();

            sports.Add(new Sport() { SportName = "Koşu", BurningCalori = 565 });
            sports.Add(new Sport() { SportName = "Yüzme", BurningCalori = 650 });
            sports.Add(new Sport() { SportName = "Yürüyüş", BurningCalori = 500 });
            sports.Add(new Sport() { SportName = "Bisiklet", BurningCalori = 600 });
            sports.Add(new Sport() { SportName = "Tenis", BurningCalori = 450 });
            sports.Add(new Sport() { SportName = "Futbol", BurningCalori = 588 });
            sports.Add(new Sport() { SportName = "Pilates", BurningCalori = 200 });
            sports.Add(new Sport() { SportName = "Basketbol", BurningCalori = 440 });
            sports.Add(new Sport() { SportName = "Voleybol", BurningCalori = 294 });
            sports.Add(new Sport() { SportName = "Golf", BurningCalori = 390 });
            sports.Add(new Sport() { SportName = "Ağırlık Çalışması", BurningCalori = 440 });
            


            context.Sports.AddRange(sports);
            

        }
    }
}
