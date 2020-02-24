using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hotelsFilePath = @"./hotels.xml";
            string customersFilePath = @"./customers.xml";
            string roomsFilePath = @"./rooms.xml";

            List<Customer> customers = new List<Customer>();
            customers.Add(
                new Customer("John", "Helsinki 2A", "B12", "10-10-2019", 14)
            );
            customers.Add(
                new Customer("Joe", "Helsinki 7C", "E34", "10-10-2019", 14)
            );

            List<Room> rooms = new List<Room>();
            rooms.Add(
                new Room("B12", 64.0, RoomType.Studio, 150.0, "Great room!")
            );
            rooms.Add(
                new Room("E34", 32.0, RoomType.Double, 70.0, "Good room!")
            );

            List<Hotel> hotels = new List<Hotel>();
            hotels.Add(
                new Hotel("Sunny Hotel", "6-4-1987", "Helsinki 43D", 5, rooms, customers)
            );

            Console.WriteLine(Customer.WriteXML(customers, customersFilePath));
            Console.WriteLine(Room.WriteXML(rooms, roomsFilePath));
            Console.WriteLine(Hotel.WriteXML(hotels, hotelsFilePath));

            List<Customer> xmlCustomers = Customer.ReadXML<List<Customer>>(customersFilePath);
            List<Room> xmlRooms = Room.ReadXML<List<Room>>(roomsFilePath);
            List<Hotel> xmlHotels = Hotel.ReadXML<List<Hotel>>(hotelsFilePath);

            foreach (Customer customer in xmlCustomers)
            {
                Console.Out.WriteLine(customer);
            }

            foreach (Room room in xmlRooms)
            {
                Console.Out.WriteLine(room);
            }

            foreach (Hotel hotel in xmlHotels)
            {
                Console.Out.WriteLine(hotel);
            }
        }
    }
}
