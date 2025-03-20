using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_02
{
    abstract class Resident
    {
        public string Name { get; set; }
        public int FoodUsed { get; set; }

        protected static Random random = new Random();

        public Resident()
        {
            Name = "Unknown";
            FoodUsed = 0;
        }
        public abstract int Eat();
        public override string ToString()
        {
            return $"{Name} used {FoodUsed}";
        }
    }
}
