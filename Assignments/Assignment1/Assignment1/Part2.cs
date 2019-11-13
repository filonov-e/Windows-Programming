using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Part2
    {
        
        static void AddCustomerDialog(ref List<Customer> customers)
        {
            Console.WriteLine("\nEnter name:");
            string name = Console.ReadLine();

            string id;

            while (true)
            {
                Console.WriteLine("Enter id:");
                id = Console.ReadLine();

                if (customers.Any(customer => customer.Id.Equals(id)))
                {
                    Console.WriteLine("Id is already in use.");
                } else
                {
                    break;
                }
            }

            Console.WriteLine("Enter flight id:");
            string flightId = Console.ReadLine();

            customers.Add(new Customer(name, id, flightId));

            Console.WriteLine("Added new customer:");
            customers.Last().Print();
        }

        static void AddFlightDialog(ref List<Flight> flights)
        {
            string id;

            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Enter id:");
                id = Console.ReadLine();

                if (flights.Any(flight => flight.Id.Equals(id)))
                {
                    Console.WriteLine("Id is already in use.");
                } else
                {
                    break;
                }
            }

            Console.WriteLine("Enter origin:");
            string origin = Console.ReadLine();

            Console.WriteLine("Enter destination:");
            string destination = Console.ReadLine();

            Console.WriteLine("Enter date:");
            string date = Console.ReadLine();

            flights.Add(new Flight(id, origin, destination, date));

            Console.WriteLine("Added new flight:");
            flights.Last().Print();
        }

        static void FindFlightDialog(List<Customer> customers, List<Flight> flights)
        {
            Console.WriteLine("\nEnter flight id:");
            string id = Console.ReadLine();
            Flight myFlight = flights.Find(flight => flight.Id.Equals(id));

            if (myFlight != null)
            {
                Console.WriteLine("Flight found:");
                myFlight.Print();
                Console.WriteLine("Passengers:");
                foreach (Customer customer in customers.Where(customerItem => customerItem.FlightId.Equals(id)))
                {
                    customer.Print();
                }
            }
        }

        static void FindCustomerDialog(List<Customer> customers, List<Flight> flights)
        {
            Console.WriteLine("\nEnter customer id:");
            string id = Console.ReadLine();
            Customer myCustomer = customers.Find(customer => customer.Id.Equals(id));

            if (myCustomer != null)
            {
                Console.WriteLine("Customer found:");
                myCustomer.Print();
                Console.WriteLine("Flight information:");
                myCustomer.getFlightInfo(flights)?.Print();
            }
        }

        public static void Run()
        {
            Console.WriteLine("Running part 2...");

            List<Customer> customers = new List<Customer>();
            List<Flight> flights = new List<Flight>();

            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("[addc]: Add new customer record");
                Console.WriteLine("[addf]: Add new flight record");
                Console.WriteLine("[findc]: Search through customer records");
                Console.WriteLine("[findf]: Search through flight records");
                Console.WriteLine("[exit]: Exit program");
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "addc":
                        AddCustomerDialog(ref customers);
                        break;
                    case "addf":
                        AddFlightDialog(ref flights);
                        break;
                    case "findc":
                        FindCustomerDialog(customers, flights);
                        break;
                    case "findf":
                        FindFlightDialog(customers, flights);
                        break;
                    case "exit":
                        Console.WriteLine("Terminating the program...");
                        return;
                }
            }
        }
    }
}
