using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_02
{
    class Civilian : Resident
    {
        private static int counter = 1;
        public Civilian() :base()
        {
            Name = $"Civilian #{counter}";
            FoodUsed = Eat();
            counter++;
        }
        public override int Eat()
        {
            return random.Next(10, 15);
        }
        public override string ToString()
        {
            return $"{Name} eaten only {FoodUsed}";
        }
    }
}
