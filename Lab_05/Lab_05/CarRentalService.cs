using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class CarRentalService
    {
        public CarFactory carFactory;
        public CarRentalService(CarFactory _carFactory)
        {
            carFactory = _carFactory;
        }

        public void Rent()
        {
            Vehicle v = carFactory.Create();
            Console.WriteLine($"We can offer you following car: {v}");
        }
    }
}
