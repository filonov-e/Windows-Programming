using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    class AirlineCompany
    {
        private readonly string Name;
        private List<Flight> Flights = new List<Flight>();

        public Flight this[int index]
        {
            set
            {
                Flights.Insert(index, value);
            }

            get
            {
                return Flights[index];
            }
        }

        public AirlineCompany(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public string FindFlight(string Id)
        {
            Flight filteredFilghts = Flights.Find((FlightItem) => (
                FlightItem.GetId().Equals(Id)
            ));

            string filteredInfo = filteredFilghts.GetFlightInfo();

            return filteredInfo;
        }

        public List<Flight> GetFlights()
        {
            return Flights;
        }
    }
}
