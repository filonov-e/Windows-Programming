using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
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

            FlightDelegate fd1 = new FlightDelegate(FlightActions.GetInfo);
            FlightDelegate fd2 = new FlightDelegate(FlightActions.GetFullInfo);

            string info1FromDelegate = company[0].MethodForDelegate(fd1, 5.99);
            string info2FromDelegate = company[0].MethodForDelegate(fd2, 6.99);
            string info3FromDelegate = company[0].MethodForDelegate(fd1, 12.99);
            Console.WriteLine("Info 1");
            Console.WriteLine(info1FromDelegate);
            Console.WriteLine("Info 2");
            Console.WriteLine(info2FromDelegate);
            Console.WriteLine("Info 3");
            Console.WriteLine(info3FromDelegate);
        }
    }
}
