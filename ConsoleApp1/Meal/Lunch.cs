using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Lunch
    {
        private string _lunchType;

        public Dish FirstCourse { get; set; }
        public Dish SecondCourse { get; set; }
        public Drink Drink { get; set; }
        public List<string> Ingredients { get; set; }

        public Lunch(string type)
        {
            _lunchType = type;
            Ingredients = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine("\nYour order\nLunch: " + _lunchType);

            Console.Write("First course - " + FirstCourse.ToString());
            Console.Write("Second course - " + SecondCourse.ToString());
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
