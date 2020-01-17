using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight fl = new Flight("111", "Vaasa", "Helsinki", "2020-10-10");
            EconomyPassenger ep = new EconomyPassenger(23.0f, "222", "Egor", "Filonov", "123123123");
            ep[0] = new Ticket("333", "222", fl, 299.99f);
            Console.WriteLine(ep.GetInfo());
        }
    }
}
