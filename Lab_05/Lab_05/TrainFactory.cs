using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class TrainFactory:VehicleFactory
    {
        public override Vehicle Create()
        {
            Train train = new Train("hybrid", 120);
            return train;
        }
    }
}
