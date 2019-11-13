using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Flight
    {
        public string Id { get; private set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public string Date { get; private set; }

        public Flight (string Id, string Origin, string Destination, string Date)
        {
            this.Id = Id;
            this.Origin = Origin;
            this.Destination = Destination;
            this.Date = Date;
        }

        public void Print()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Origin: {0}", Origin);
            Console.WriteLine("Destination: {0}", Destination);
            Console.WriteLine("Date: {0}\n", Date);
        }
    }
}
