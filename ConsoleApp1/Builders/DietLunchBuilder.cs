using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class DietLunchBuilder : LunchBuilder
    {
        // Ingredients
        private bool _addPeppers;
        private bool _addTomatoes;
        private bool _addPeanuts;

        // Drinks
        private bool _addAppleJuice;
        private bool _addFruitDrink;

        public DietLunchBuilder(bool addPeppers, bool addTomatoes, bool addPeanuts,
            bool addAppleJuice, bool addFruitDrink)
        {
            Lunch = new Lunch("Diet Lunch");
            _addPeppers = addPeppers;
            _addTomatoes = addTomatoes;
            _addPeanuts = addPeanuts;
            _addAppleJuice = addAppleJuice;
            _addFruitDrink = addFruitDrink;
        }

        public override void BuildFirstCourse()
        {
            Lunch.FirstCourse = new Dish("Cream soup");
        }

        public override void BuildSecondCourse()
        {
            Lunch.SecondCourse = new Dish("Fried beans");
        }

        public override void BuildIngredients()
        {
            if (_addPeppers)
            {
                Lunch.Ingredients.Add("Peppers");
            }
            if (_addTomatoes)
            {
                Lunch.Ingredients.Add("Tomatoes");
            }
            if (_addPeanuts)
            {
                Lunch.Ingredients.Add("Peanuts");
            }
        }

        public override void BuildDrink()
        {
            if (_addAppleJuice)
            {
                Lunch.Drink = new Drink("Apple juice");
            }
            else if (_addFruitDrink)
            {
                Lunch.Drink = new Drink("Fruit Drink");
            }
        }
    }
}
