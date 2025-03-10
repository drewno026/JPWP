using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Flamingo:Bird
    {
        public Flamingo() : base() { }
        public Flamingo(string _name, int _weight, int _numberOfFeathers) : base(_name, _weight, _numberOfFeathers){ }

        public void Incubation(int number, int days)
        {
            LayEggs(number);
            Console.WriteLine($"Days of incubation {days}");
        }
    }
}
