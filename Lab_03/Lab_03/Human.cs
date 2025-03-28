using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    abstract class Human:ITransportable
    {
        protected double volume, weight;
        public abstract void Work(double time); 
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = volume * 0.5;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = weight / 0.5;
            }
        }
    }
}
