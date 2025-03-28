using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public class Waste:IVisitPort
    {
        private double volume, weight;
        
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
        public double VisitPort()
        {
            double costPerUnint = 100.5;
            double cost = weight * costPerUnint;
            volume = 0;
            return cost;
        }
    }
}
