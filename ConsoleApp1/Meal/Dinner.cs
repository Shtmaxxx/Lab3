using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Dinner
    {
        private string _dinnerType;

        public Dish Dish { get; set; }
        public Drink Drink { get; set; }
        public List<string> Ingredients { get; set; }

        public Dinner(string type)
        {
            _dinnerType = type;
            Ingredients = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine("\nYour order\nDinner: " + _dinnerType);
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
