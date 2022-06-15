using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BestDietDbContext : DbContext
    {
        public BestDietDbContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BestDietDbContext>());
        }
        public DbSet<User> Users { get; set; }
    }
}
