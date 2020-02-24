using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter hotelsBinaryWriter;
            BinaryWriter customersBinaryWriter;
            BinaryWriter roomsBinaryWriter;

            BinaryReader hotelsBinaryReader;
            BinaryReader customersBinaryReader;
            BinaryReader roomsBinaryReader;

            string hotelsFilePath = @"./hotels.dat";
            string customersFilePath = @"./customers.dat";
            string roomsFilePath = @"./rooms.dat";

            try
            {
                hotelsBinaryWriter = new BinaryWriter(new FileStream(hotelsFilePath, FileMode.OpenOrCreate));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + hotelsFilePath);
                return;
            }

            try
            {
                customersBinaryWriter = new BinaryWriter(new FileStream(customersFilePath, FileMode.OpenOrCreate));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + customersFilePath);
                return;
            }

            try
            {
                roomsBinaryWriter = new BinaryWriter(new FileStream(roomsFilePath, FileMode.OpenOrCreate));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + roomsFilePath);
                return;
            }

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
            Hotel hotel = new Hotel("Sunny Hotel", "6-4-1987", "Helsinki 43D", 5, rooms, customers);

            try
            {
                hotelsBinaryWriter.Write(hotel.ToString());

                foreach (Customer customer in customers)
                {
                    customersBinaryWriter.Write(customer.ToString());
                }

                foreach (Room room in rooms)
                {
                    roomsBinaryWriter.Write(room.ToString());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nWrite error.");
            }

            hotelsBinaryWriter.Close();
            customersBinaryWriter.Close();
            roomsBinaryWriter.Close();

            try
            {
                hotelsBinaryReader = new BinaryReader(new FileStream(hotelsFilePath, FileMode.Open));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + hotelsFilePath);
                return;
            }

            try
            {
                customersBinaryReader = new BinaryReader(new FileStream(customersFilePath, FileMode.Open));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + customersFilePath);
                return;
            }

            try
            {
                roomsBinaryReader = new BinaryReader(new FileStream(roomsFilePath, FileMode.Open));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message + "\nCannot open " + roomsFilePath);
                return;
            }

            try
            {
                for (;;)
                {
                    // Read an inventory entry.
                    string item = hotelsBinaryReader.ReadString();
                    
                    /* See if the item matches the one requested.
                    If so, display information */
                    Console.WriteLine(item);
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("End of file!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Read error." + e.Message);
            }

            try
            {
                for (;;)
                {
                    // Read an inventory entry.
                    string item = customersBinaryReader.ReadString();

                    /* See if the item matches the one requested.
                    If so, display information */
                    Console.WriteLine(item);
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("End of file!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Read error." + e.Message);
            }

            try
            {
                for (;;)
                {
                    // Read an inventory entry.
                    string item = roomsBinaryReader.ReadString();

                    /* See if the item matches the one requested.
                    If so, display information */
                    Console.WriteLine(item);
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("End of file!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Read error." + e.Message);
            }
        }
    }
}
