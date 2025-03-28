using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    abstract class Fuel:ITransportable
    {
        public double volume, weight;
        protected double density;

        public abstract string Type { get; }
        public abstract new string GetType();

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = weight / density;
            }
        }
    }
}
