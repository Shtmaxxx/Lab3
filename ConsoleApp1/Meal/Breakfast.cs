using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Breakfast
    {
        private string _breakfastType;

        public Dish Dish { get; set; }
        public Drink Drink { get; set; }
        public List<string> Ingredients { get; set; }

        public Breakfast(string type)
        {
            _breakfastType = type;  
            Ingredients = new List<string>();   
        }

        public void Display()
        {
            Console.WriteLine("\nYour order\nBreakfast: " + _breakfastType);
            Console.WriteLine(Dish.ToString());
            Console.Write("Ingredients: ");
            foreach (var ing in Ingredients)
            {
                Console.Write(ing + "; ");
            }
            if (Drink != null)
            {
                Console.WriteLine("\n" + Drink.ToString());
            }
            else
            {
                Console.WriteLine("\nNo drinks ordered");
            }
        }
    }
}
