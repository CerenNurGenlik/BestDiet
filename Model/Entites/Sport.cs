using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Sport
    {
        public Sport()
        {
            Exercises = new HashSet<Exercise>();
        }
        public int SportID { get; set; }
        public string SportName { get; set; }
        public int BurningCalori { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
