using ConsoleApp1.Builders;
using ConsoleApp1.Meal;
using ConsoleApp1.Utils;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variant 6");

            Restaurant restaurant = new Restaurant();

            try
            {
                Printer.SelectMeal();
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        ManageBreakfastOrder(restaurant);
                        break;
                    case 2:
                        ManageLunchOrder(restaurant);
                        break;
                    case 3:
                        ManageDinnerOrder(restaurant);
                        break;
                    default: 
                        throw new Exception("Incorrect number!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError! " + ex.Message + "\n");
            }

        }

        static void ManageBreakfastOrder(Restaurant restaurant)
        {
            Printer.SelectBreakfastType();
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                bool addJam = false;
                bool addChocolate = false;
                bool addTea = false;
                bool addCoffee = false;

                Printer.AddJam();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addJam = true;
                }

                Printer.AddChocolate();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addChocolate = true;
                }

                Printer.ContinentalBreakfastDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTea = true;
                }
                else if (t == 2)
                {
                    addCoffee = true;
                }

                BreakfastBuilder breakfastBuilder = new ContinentalBreakfastBuilder(addJam, addChocolate, addTea, addCoffee);
                restaurant.OrderBreakfast(breakfastBuilder);
                breakfastBuilder.GetBreakfast.Display();
            }
            else if (n == 2)
            {
                bool addBacon = false;
                bool addTomatoes = false;
                bool addMushrooms = false;
                bool addTea = false;
                bool addOrangeJuice = false;

                Printer.AddBacon();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addBacon = true;
                }

                Printer.AddTomatoes();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTomatoes = true;
                }

                Printer.AddMushrooms();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addMushrooms = true;
                }

                Printer.EnglishBreakfastDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTea = true;
                }
                else if (t == 2)
                {
                    addOrangeJuice = true;
                }

                BreakfastBuilder breakfastBuilder = new EnglishBreakfastBuilder(addBacon, addTomatoes, addMushrooms, addTea, addOrangeJuice);
                restaurant.OrderBreakfast(breakfastBuilder);
                breakfastBuilder.GetBreakfast.Display();
            }
            else
            {
                throw new Exception("Incorrect number!");
            }
        }

        static void ManageLunchOrder(Restaurant restaurant)
        {
            Printer.SelectLunchType();
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                bool addPeppers = false;
                bool addTomatoes = false;
                bool addPeanuts = false;
                bool addAppleJuice = false;
                bool addFruitDrink = false;

                Printer.AddPeppers();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addPeppers = true;
                }

                Printer.AddLunchTomatoes();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTomatoes = true;
                }

                Printer.AddPeanuts();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addPeanuts = true;
                }

                Printer.DietLunchDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addAppleJuice = true;
                }
                else if (t == 2)
                {
                    addFruitDrink = true;
                }

                LunchBuilder lunchBuilder = new DietLunchBuilder(addPeppers, addTomatoes, addPeanuts, addAppleJuice, addFruitDrink);
                restaurant.OrderLunch(lunchBuilder);
                lunchBuilder.GetLunch.Display();
            }
            else if (b == 2)
            {
                bool addSauce = false;
                bool addAppleJuice = false;
                bool addCola = false;

                Printer.AddSauce();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addSauce = true;
                }

                Printer.RegularLunchDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addAppleJuice = true;
                }
                else if (t == 2)
                {
                    addCola = true;
                }

                LunchBuilder lunchBuilder = new RegularLunchBuilder(addSauce, addAppleJuice, addCola);
                restaurant.OrderLunch(lunchBuilder);
                lunchBuilder.GetLunch.Display();
            }
            else
            {
                throw new Exception("Incorrect number!");
            }
        }

        static void ManageDinnerOrder(Restaurant restaurant)
        {
            Printer.SelectDinnerType();
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                bool addIcebergLettuce = false;
                bool addTea = false;
                bool addFruitDrink = false;

                Printer.AddIceberg();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addIcebergLettuce = true;
                }

                Printer.DietDinnerhDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTea = true;
                }
                else if (t == 2)
                {
                    addFruitDrink = true;
                }

                DinnerBuilder dinnerBuilder = new DietDinnerBuilder(addIcebergLettuce, addTea, addFruitDrink);
                restaurant.OrderDinner(dinnerBuilder);
                dinnerBuilder.GetDinner.Display();
            }
            else if (n == 2)
            {
                bool addSauce = false;
                bool addSalad = false;
                bool addTea = false;
                bool addCola = false;

                Printer.AddSauce();
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addSauce = true;
                }

                Printer.AddSalad();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addSalad = true;
                }

                Printer.RegularDinnerhDrink();
                t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    addTea = true;
                }
                else if (t == 2)
                {
                    addCola = true;
                }

                DinnerBuilder dinnerBuilder = new RegularDinnerBuilder(addSauce, addSalad, addTea, addCola);
                restaurant.OrderDinner(dinnerBuilder);
                dinnerBuilder.GetDinner.Display();
            }
            else
            {
                throw new Exception("Incorrect number!");
            }
        }
    }
}
