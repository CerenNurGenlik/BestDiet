using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ExerciseDetailService
    {
        ExerciseRepository exerciseRepository;
        ExerciseDetailRepository exerciseDetailRepository;

        public ExerciseDetailService()
        {
            exerciseRepository = new ExerciseRepository();
            exerciseDetailRepository = new ExerciseDetailRepository();
        }

        public List<ExerciseDetail> GetSportsByExercise (string userID,  DateTime dateTime)
        {
            Exercise exercise = exerciseRepository.GetExercise(userID, dateTime);

            List<ExerciseDetail> exerciseDetails = exerciseDetailRepository.GetExerciseDetails(exercise.ExerciseID);

            return exerciseDetails;
        }

        void CheckExerciseDetailId(int exerciseDetailId)
        {
            if (exerciseDetailId <= 0) throw new Exception("Egzersiz bulunamadı");
        }

        public bool Delete(int exerciseDetailID)
        {
            CheckExerciseDetailId(exerciseDetailID);
            return exerciseDetailRepository.Delete(exerciseDetailID);
        }

        public bool Insert(ExerciseDetail exerciseDetail)
        {
            CheckExerciseDetailId(exerciseDetail.ExerciseDetailID);
            return exerciseDetailRepository.Insert(exerciseDetail);
        }
        public bool Update(ExerciseDetail exerciseDetail)
        {
            CheckExerciseDetailId(exerciseDetail.ExerciseDetailID);
            return exerciseDetailRepository.Update(exerciseDetail);
        }
    }
}
