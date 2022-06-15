using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Food
    {
        public Food()
        {
            Meals = new HashSet<Meal>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Calori { get; set; }
        public int FoodCategoryID { get; set; }
        public bool IsActive { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
