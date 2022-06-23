using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class RegularDinnerBuilder : DinnerBuilder
    {
        private bool _addSauce;
        private bool _addSalad;

        private bool _addTea;
        private bool _addCola;


        public RegularDinnerBuilder(bool addSauce, bool addSalad, bool addTea, bool addCola)
        {
            Dinner = new Dinner("Regular Dinner");
            _addSauce = addSauce;
            _addSalad = addSalad;
            _addTea = addTea;
            _addCola = addCola;
        }

        public override void BuildDish()
        {
            Dinner.Dish = new Dish("Fried popatoes with steak");
        }

        public override void BuildIngredients()
        {
            if (_addSauce)
            {
                Dinner.Ingredients.Add("Sauce");
            }
            if (_addSalad)
            {
                Dinner.Ingredients.Add("Salad");
            }
        }

        public override void BuildDrink()
        {
            if (_addTea)
            {
                Dinner.Drink = new Drink("Tea");
            }
            else if (_addCola)
            {
                Dinner.Drink = new Drink("Cola");
            }
        }
    }
}
