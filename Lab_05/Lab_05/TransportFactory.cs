using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_05
{
    abstract class TransportFactory
    {
        protected string travelMode = "quickest"; // initial value
        public string TravelMode
        {
            get { return travelMode; }
            set
            {
                // available travel modes: quickest route, cheapest route, most convenient route
                if (value == "quickest" || value == "cheapest" || value == "convenient") travelMode = value;
                else Console.WriteLine($"Unrecognized travel mode: {value}");
            }
        }

        public abstract Vehicle CreateVehicle();

        public abstract Ticket? CreateTicket();

    }
}
