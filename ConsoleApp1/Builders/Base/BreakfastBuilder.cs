using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    abstract class BreakfastBuilder
    {
        protected Breakfast Breakfast;

        public Breakfast GetBreakfast
        {
            get { return Breakfast; }
        }

        public abstract void BuildDish();
        public abstract void BuildIngredients();
        public abstract void BuildDrink();
    }
}
