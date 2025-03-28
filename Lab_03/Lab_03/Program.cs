﻿using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // before we construct a submarine, test individual elements of the program first
            bool testsPassed = TestSubmarine.Run();
            if (!testsPassed) return;
            Console.WriteLine();

            // now we are ready for the submarine simulation
            Submarine.Demo();
        }
    }
}
