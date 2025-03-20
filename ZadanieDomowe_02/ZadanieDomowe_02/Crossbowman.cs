using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_02
{
    class Crossbowman:Defender
    {
        private static int counter = 1;

        public Crossbowman() : base() 
        {
            Name = $"Crossbowman #{counter}";
            counter++;
        }

        public override string ReadyToFight()
        {
            return $"{Name} is not ready";
        }
        public override string ToString()
        {
            return $"{Name} consumed {FoodUsed}";
        }
    }
}
