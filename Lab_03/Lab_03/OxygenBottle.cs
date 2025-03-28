using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class OxygenBottle : IVisitPort
    {
        private double volume, weight;

        private const double oxygenDensity = 1.0;

        public OxygenBottle(double _maxCapacity)
        {
            MaxCapacity = _maxCapacity;
        }

        public double MaxCapacity { get; private set; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = volume * oxygenDensity;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = weight / oxygenDensity;
            }
        }
        public double GetMaxCapacity()
        {
            return MaxCapacity;
        }
        public double VisitPort()
        {
            double missingVolume = MaxCapacity - volume;
            double costPerUnit = 1;
            double costs = missingVolume * costPerUnit;
            volume = MaxCapacity;
            return costs;
        }
    }
}
