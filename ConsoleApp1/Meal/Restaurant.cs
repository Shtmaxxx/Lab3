using ConsoleApp1.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Restaurant
    {
        public void OrderBreakfast(BreakfastBuilder breakfastBuilder)
        {
            breakfastBuilder.BuildDish();
            breakfastBuilder.BuildIngredients();
            breakfastBuilder.BuildDrink();
        }

        public void OrderLunch(LunchBuilder lunchBuilder)
        {
            lunchBuilder.BuildFirstCourse();
            lunchBuilder.BuildSecondCourse();
            lunchBuilder.BuildIngredients();
            lunchBuilder.BuildDrink();
        }

        public void OrderDinner(DinnerBuilder dinnerBuilder)
        {
            dinnerBuilder.BuildDish();
            dinnerBuilder.BuildIngredients();
            dinnerBuilder.BuildDrink();
        }
    }
}
