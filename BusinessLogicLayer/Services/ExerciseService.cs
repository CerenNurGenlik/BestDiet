﻿using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    class ExerciseService
    {
        ExerciseRepository exerciseRepository;
        public ExerciseService()
        {
            exerciseRepository = new ExerciseRepository();
        }

        public List<Exercise> GetExercisesByDate(DateTime dateTime)
        {
            List<Exercise> exerciseList = new List<Exercise>();
            exerciseList = exerciseRepository.GetExercisesByDate(dateTime);
            return exerciseList;
        }
    }
}
