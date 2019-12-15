using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany company = new AirlineCompany("S7");
            company[0] = new Flight("1", "Vaasa", "Helsinki", "01.01.2020", 10.99);
            company[1] = new Flight("2", "Helsinki", "Stockholm", "02.02.2020", 11.99);
            company[2] = new Flight("3", "Stockholm", "Oulu", "03.03.2020", 12.99);
            company[3] = new Flight("4", "Oulu", "Vaasa", "04.04.2020", 13.99);

            Console.WriteLine(company.GetName());
            Console.WriteLine(company.FindFlight("1"));
            Console.WriteLine(company.FindFlight("3"));

            Action<List<Flight>, double> printLowerPriceFlights = (List<Flight> Flights, double Price) =>
            {
                List<Flight> filteredFlights = Flights.FindAll((FlightItem) => (
                    FlightItem.GetPrice() < Price
                ));

                Console.WriteLine("Displaying flights with price lower than {0:N2}", Price);

                filteredFlights.ForEach((FlightItem) => {
                    Console.WriteLine(FlightItem.GetFlightInfo());
                });
            };

            company.PrintFlightsWithDelegate(printLowerPriceFlights, 13.00);
        }
    }
}
