using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class FoodContainer:IVisitPort
    {
        private double volume, weight;

        private const double foodDensity = 1.0;

        public FoodContainer(double _maxCapacity)
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
                weight = volume * foodDensity;
            }
        }
        public double Weight
        {
            get { return weight; }
            set 
            {
                weight = value;
                volume = weight / foodDensity;
            }
        }
        public double GetMaxCapacity()
        {
            return MaxCapacity;
        }
        public double VisitPort()
        {
            double missingVolume = MaxCapacity - volume;
            double costPerUnit = 10;
            double costs = volume * costPerUnit;
            volume = MaxCapacity;
            return costs;
        }
    }
}
