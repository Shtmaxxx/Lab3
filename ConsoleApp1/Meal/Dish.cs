using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Dish
    {
        protected string DishName;

        public Dish(string name)
        {
            DishName = name;
        }

        public override string ToString()
        {
            return $"Dish: {DishName}\n";
        }
    }
}
