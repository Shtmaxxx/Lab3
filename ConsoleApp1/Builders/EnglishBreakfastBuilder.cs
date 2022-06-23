using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class EnglishBreakfastBuilder : BreakfastBuilder
    {
        // Ingredients
        private bool _addBacon;
        private bool _addTomatoes;
        private bool _addMushrooms;

        // Drinks
        private bool _addTea;
        private bool _addOrangeJuice;

        public EnglishBreakfastBuilder(bool addBacon, bool addTomatoes, bool addMushrooms,
            bool addTea, bool addOrangeJuice)
        {
            Breakfast = new Breakfast("English Breakfast");
            _addBacon = addBacon;
            _addTomatoes = addTomatoes;
            _addMushrooms = addMushrooms;
            _addTea = addTea;
            _addOrangeJuice = addOrangeJuice;
        }

        public override void BuildDish()
        {
            Breakfast.Dish = new Dish("Fried eggs");
        }

        public override void BuildIngredients()
        {
            if (_addBacon)
            {
                Breakfast.Ingredients.Add("Bacon");
            }
            if (_addTomatoes)
            {
                Breakfast.Ingredients.Add("Tomatoes");
            }
            if (_addMushrooms)
            {
                Breakfast.Ingredients.Add("Mushrooms");
            }
        }

        public override void BuildDrink()
        {
            if (_addTea)
            {
                Breakfast.Drink = new Drink("Tea");
            }
            else if (_addOrangeJuice)
            {
                Breakfast.Drink = new Drink("Orange Juice");
            }
        }
    }
}
