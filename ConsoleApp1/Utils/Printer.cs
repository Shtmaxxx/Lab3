using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    static class Printer
    {
        static public void SelectMeal()
        {
            Console.WriteLine("Please select a meal (type a corresponding number): ");
            Console.WriteLine("1 - Breakfast");
            Console.WriteLine("2 - Lunch");
            Console.WriteLine("3 - Dinner");
        }


        // Breakfast
        static public void SelectBreakfastType()
        {
            Console.WriteLine("\nSelect Breakfast type: ");
            Console.WriteLine("1 - Continental breakfast");
            Console.WriteLine("2 - English breakfast");
        }

        static public void AddJam()
        {
            Console.WriteLine("\nWould you like to add jam?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddChocolate()
        {
            Console.WriteLine("\nWould you like to add chocolate?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void ContinentalBreakfastDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Tea");
            Console.WriteLine("2 - Coffee");
            Console.WriteLine("Another number - Nothing");
        }

        static public void AddBacon()
        {
            Console.WriteLine("\nWould you like to add bacon?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddTomatoes()
        {
            Console.WriteLine("\nWould you like to add tomatoes?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddMushrooms()
        {
            Console.WriteLine("\nWould you like to add mushrooms?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void EnglishBreakfastDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Tea");
            Console.WriteLine("2 - Orange juice");
            Console.WriteLine("Another number - Nothing");
        }

        // Lunch
        static public void SelectLunchType()
        {
            Console.WriteLine("\nSelect Lunch type: ");
            Console.WriteLine("1 - Diet lunch");
            Console.WriteLine("2 - Regular lunch");
        }

        static public void AddPeppers()
        {
            Console.WriteLine("\nWould you like to add peppers to the second course?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddLunchTomatoes()
        {
            Console.WriteLine("\nWould you like to add tomatoes to the second course?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddPeanuts()
        {
            Console.WriteLine("\nWould you like to add peanuts to the second course?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void DietLunchDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Apple juice");
            Console.WriteLine("2 - Fruit drink");
            Console.WriteLine("Another number - Nothing");
        }

        static public void AddSauce()
        {
            Console.WriteLine("\nWould you like to add sauce to the second course?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void RegularLunchDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Apple juice");
            Console.WriteLine("2 - Cola");
            Console.WriteLine("Another number - Nothing");
        }

        // Dinner 
        static public void SelectDinnerType()
        {
            Console.WriteLine("\nSelect Dinner type: ");
            Console.WriteLine("1 - Diet dinner");
            Console.WriteLine("2 - Regular dinner");
        }
        static public void AddIceberg()
        {
            Console.WriteLine("\nWould you like to add iceberg lettuce?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }
        static public void DietDinnerhDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Tea");
            Console.WriteLine("2 - Fruit drink");
            Console.WriteLine("Another number - Nothing");
        }

        static public void AddDinnerSauce()
        {
            Console.WriteLine("\nWould you like to add dinner sauce?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void AddSalad()
        {
            Console.WriteLine("\nWould you like to add salad?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("Another number - No");
        }

        static public void RegularDinnerhDrink()
        {
            Console.WriteLine("\nSelect a drink: ");
            Console.WriteLine("1 - Tea");
            Console.WriteLine("2 - Cola");
            Console.WriteLine("Another number - Nothing");
        }
    }
}
