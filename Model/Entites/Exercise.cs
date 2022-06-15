using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public DateTime ExerciseDate { get; set; }
        public string UserID { get; set; }
        public int SportID { get; set; }

        public virtual User User { get; set; }
        public virtual Sport Sport { get; set; }
    }
}
