using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Animal
    {
        public string Name { get; set; }

        protected int weight;

        private int age;

        public Animal() 
        {
            Name = "Unwknown";
            weight = 0;
            age = 0;
        }
        public Animal(string _name, int _weight)
        {
            Name = _name;
            weight = _weight;
        }
        public void Info()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Weight:{weight}");
            Console.WriteLine($"Age:{age}");
        }
    }
}
