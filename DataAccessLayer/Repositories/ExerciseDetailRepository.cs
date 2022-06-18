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
        public List<ExerciseDetail> GetExerciseDetails(int exerciseID)
        {
            return MainRepository.db.ExerciseDetails.Where(a => a.ExerciseID == exerciseID).ToList();
        }
        public List<ExerciseDetail> GetExerciseDetailsBetweenDate(string userID,DateTime dateTime,DateTime dateTime2)
        {
            return MainRepository.db.ExerciseDetails.Where(a => a.Exercise.UserID == userID && a.Exercise.ExerciseDate>=dateTime && a.Exercise.ExerciseDate<=dateTime2).ToList();
        }

        public List<ExerciseDetail> GetExerciseDetailsByUserId(string userID)
        {
            return MainRepository.db.ExerciseDetails.Where(a => a.Exercise.UserID==userID).ToList();
        }

        public bool Delete(int exerciseDetailId)
        {
            ExerciseDetail exerciseDetail = MainRepository.db.ExerciseDetails.Where(a => a.ExerciseDetailID == exerciseDetailId).FirstOrDefault();
            MainRepository.db.ExerciseDetails.Remove(exerciseDetail);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Insert(ExerciseDetail exerciseDetail)
        {
            MainRepository.db.ExerciseDetails.Add(exerciseDetail);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Update(ExerciseDetail exerciseDetail)
        {
            ExerciseDetail updatedExerciseDetail = MainRepository.db.ExerciseDetails.Find(exerciseDetail.ExerciseDetailID);
            updatedExerciseDetail.BurningCalori = exerciseDetail.BurningCalori;
            updatedExerciseDetail.Minute = exerciseDetail.Minute;

            return MainRepository.db.SaveChanges() > 0;
        }
        public ExerciseDetail GetExerciseDetailById(int exercesiDetailId)
        {
            ExerciseDetail exerciseDetail = MainRepository.db.ExerciseDetails.Find(exercesiDetailId);
            return exerciseDetail;
        }
    }
}
