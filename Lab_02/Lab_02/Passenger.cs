using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    abstract class Passenger:IBuyTicket
    {
        public void BuyTicket()
        {
            Console.WriteLine("Ticket bought");
        }
    }
}
