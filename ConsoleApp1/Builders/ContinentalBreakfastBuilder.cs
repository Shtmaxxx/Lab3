using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class ContinentalBreakfastBuilder : BreakfastBuilder
    {
        // Ingredients
        private bool _addJam;
        private bool _addChocolate;

        // Drinks
        private bool _addTea;
        private bool _addCoffee;

        public ContinentalBreakfastBuilder(bool addJam, bool addChocolate, bool addTea, bool addCoffee)
        {
            Breakfast = new Breakfast("Continental Breakfast");
            _addJam = addJam;
            _addChocolate = addChocolate;
            _addTea = addTea;
            _addCoffee = addCoffee;
        }

        public override void BuildDish()
        {
            Breakfast.Dish = new Dish("Croissants");
        }

        public override void BuildIngredients()
        {
            if (_addJam)
            {
                Breakfast.Ingredients.Add("Jam");
            }
            if (_addChocolate)
            {
                Breakfast.Ingredients.Add("Chocolate");
            }
        }

        public override void BuildDrink()
        {
            if (_addTea)
            {
                Breakfast.Drink = new Drink("Tea");
            }
            else if (_addCoffee)
            {
                Breakfast.Drink = new Drink("Coffee");
            }
        }
    }
}
