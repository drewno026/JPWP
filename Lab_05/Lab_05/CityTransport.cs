using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class CityTransport:TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "quickest":
                    return new Metro();
                case "cheapest":
                    return new Car();
                case "convenient":
                    return new Bus();
                default:
                    Console.WriteLine("Unknown travel mode. Defaulting to Bus.");
                    return new Bus();
            }
        }
        public override Ticket? CreateTicket()
        {
            switch (CreateVehicle())
            {
                case Metro:
                    return new MetroTicket();
                case Car:
                case Bus:
                    return new BusTicket();
                default:
                    return null;
            }
        }
    }
}
