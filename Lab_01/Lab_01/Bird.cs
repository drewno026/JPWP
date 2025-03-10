using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Bird:Animal
    {
        public int NumberOfFeathers { get; set; }
        public Bird() : base() 
        {
            NumberOfFeathers = 0;
        }
        public Bird(string _name, int _weight, int _numberOfFeathers) : base (_name, _weight) 
        {
            NumberOfFeathers = _numberOfFeathers;
        }

        public void LayEggs(int number)
        {
            Console.WriteLine($"Number of eggs: {number}");
        }
        public void InfoFeathers()
        {
            Console.WriteLine($"Number of feathers: {NumberOfFeathers}");
        }
    }
}
