using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Flight
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }

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
            Console.WriteLine("Date: {0}", Date);
        }
    }
}
