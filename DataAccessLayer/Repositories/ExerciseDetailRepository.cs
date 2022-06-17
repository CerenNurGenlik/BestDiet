using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ExerciseDetailRepository
    {
        BestDietDbContext db;
        public ExerciseDetailRepository()
        {
            db = new BestDietDbContext();
        }

        public List<ExerciseDetail> GetExerciseDetails(int exerciseID)
        {
            return db.ExerciseDetails.Where(a => a.ExerciseID == exerciseID).ToList();
        }
        public bool Delete(int exerciseDetailId)
        {
            ExerciseDetail exerciseDetail = db.ExerciseDetails.Where(a => a.ExerciseDetailID == exerciseDetailId).FirstOrDefault();
            db.ExerciseDetails.Remove(exerciseDetail);
            return db.SaveChanges() > 0;
        }
        public bool Insert(ExerciseDetail exerciseDetail)
        {
            db.ExerciseDetails.Add(exerciseDetail);
            return db.SaveChanges() > 0;
        }
        public bool Update(ExerciseDetail exerciseDetail)
        {
            ExerciseDetail updatedExerciseDetail = db.ExerciseDetails.Find(exerciseDetail.ExerciseDetailID);
            updatedExerciseDetail.BurningCalori = exerciseDetail.BurningCalori;
            updatedExerciseDetail.Minute = exerciseDetail.Minute;

            return db.SaveChanges() > 0;
        }
    }
}
