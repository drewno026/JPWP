using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_02
{
    abstract class Defender:Resident, IDefender
    {
        public Defender() : base() 
        {
            FoodUsed = Eat();
        }
        public override int Eat()
        {
            return random.Next(15, 25);
        }
        public abstract string ReadyToFight();
    }
}
