using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Customer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string FlightId { get; set; }

        public Customer(string Name, string Id, string FlightId)
        {
            this.Name = Name;
            this.Id = Id;
            this.FlightId = FlightId;
        }

        public Flight getFlightInfo(List<Flight> flights)
        {
            return flights.Find(flight => flight.Id.Equals(Id));
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("FlightId: {0}", FlightId);
        }
    }
}
