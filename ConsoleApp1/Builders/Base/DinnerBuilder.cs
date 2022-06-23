using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    abstract class DinnerBuilder
    {
        protected Dinner Dinner;

        public Dinner GetDinner
        {
            get { return Dinner; }
        }

        public abstract void BuildDish();
        public abstract void BuildIngredients();
        public abstract void BuildDrink();
    }
}
