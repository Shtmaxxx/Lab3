using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Meal
{
    class Drink
    {
        public string Name { get; set; }

        public Drink(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return "Drink: " + Name;
        }
    }
}
