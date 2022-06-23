using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class RegularLunchBuilder : LunchBuilder
    {
        private bool _addSauce;
        private bool _addAppleJuice;
        private bool _addCola;

        public RegularLunchBuilder(bool addSauce, bool addAppleJuice, bool addCola)
        {
            Lunch = new Lunch("Regular Lunch");
            _addSauce = addSauce;
            _addAppleJuice = addAppleJuice;
            _addCola = addCola;
        }

        public override void BuildFirstCourse()
        {
            Lunch.FirstCourse = new Dish("Borsch");
        }

        public override void BuildSecondCourse()
        {
            Lunch.SecondCourse = new Dish("Ravioli");
        }

        public override void BuildIngredients()
        {
            if (_addSauce)
            {
                Lunch.Ingredients.Add("Sauce");
            }
        }

        public override void BuildDrink()
        {
            if (_addAppleJuice)
            {
                Lunch.Drink = new Drink("Apple juice");
            }
            else if (_addCola)
            {
                Lunch.Drink = new Drink("Cola");
            }
        }
    }
}
