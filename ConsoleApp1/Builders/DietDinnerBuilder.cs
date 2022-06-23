using ConsoleApp1.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    class DietDinnerBuilder : DinnerBuilder
    {
        private bool _addIcebergLettuce;

        private bool _addTea;
        private bool _addFruitDrink;

        public DietDinnerBuilder(bool addLettuce, bool addTea, bool addFruitDrink)
        {
            Dinner = new Dinner("Diet Dinner");
            _addIcebergLettuce = addLettuce;
            _addTea = addTea; 
            _addFruitDrink = addFruitDrink;
        }

        public override void BuildDish()
        {
            Dinner.Dish = new Dish("Porridge with meatballs");
        }

        public override void BuildIngredients()
        {
            if (_addIcebergLettuce)
            {
                Dinner.Ingredients.Add("Iceberg lettuce");
            }
        }

        public override void BuildDrink()
        {
            if (_addTea)
            {
                Dinner.Drink = new Drink("Tea");
            }
            else if (_addFruitDrink)
            {
                Dinner.Drink = new Drink("Fruit drink");
            }
        }
    }
}
