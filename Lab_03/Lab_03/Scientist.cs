using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Scientist:Human
    {
        private Equipment equipment;
        private double hoursSinceLastUse;

        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
            hoursSinceLastUse = 0;
        }
        public override void Work(double time)
        {
            hoursSinceLastUse += time;
            if ((hoursSinceLastUse)>= 24)
            {
                string info = equipment.GatherData();
                Console.WriteLine($"Scientist used equipment after {hoursSinceLastUse} hours, Info: {info}");
                hoursSinceLastUse = 0;
            }

        }
    }
}
