using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_02
{
    class Pikeman:Defender
    {
        private static int counter = 1;
        public Pikeman() : base()
        {
            Name = $"Pikeman #{counter}";
            counter++;
        }

        public override string ReadyToFight()
        {
            return $"{Name} is ready";
        }
        public override string ToString()
        {
            return $"{Name} used {FoodUsed} food";
        }
    }
}
