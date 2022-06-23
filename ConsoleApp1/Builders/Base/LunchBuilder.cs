using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    abstract class LunchBuilder
    {
        protected Lunch Lunch;

        public Lunch GetLunch
        {
            get { return Lunch; }
        }

        public abstract void BuildFirstCourse();
        public abstract void BuildSecondCourse();
        public abstract void BuildIngredients();
        public abstract void BuildDrink();
    }
}
