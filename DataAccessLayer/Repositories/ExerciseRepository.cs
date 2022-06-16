using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ExerciseRepository
    {
        BestDietDbContext db;

        public ExerciseRepository()
        {
            db = new BestDietDbContext();
        }

        public List<Exercise> GetExercisesByDate(DateTime dateTime)
        {
            return db.Exercises.Where(m => m.ExerciseDate == dateTime).ToList();
        }
    }
}
