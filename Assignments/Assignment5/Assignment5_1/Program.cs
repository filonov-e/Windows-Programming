using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"./info.dat";
            
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            
            BinaryFormatter binaryFormatter = new BinaryFormatter();

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

            foreach (Customer customer in customers)
            {
                binaryFormatter.Serialize(fileStream, customer);
                fileStream.Flush();
            }

            foreach (Room room in rooms)
            {
                binaryFormatter.Serialize(fileStream, room);
                fileStream.Flush();
            }

            binaryFormatter.Serialize(fileStream, hotel);
            fileStream.Flush();

            fileStream.Close();

            fileStream = new FileStream(filePath, FileMode.Open);

            object obj;
            string result;

            for (;;)
            {
                try
                {
                    obj = binaryFormatter.Deserialize(fileStream);
                    //obj = soapFormatter.Deserialize(fileStream);
                    //Here we check whether obj is of type Employee
                    //or not and if it is, we type cast it to Employee
                    //and call the GetEmployee() method.
                    if (obj is Customer)
                    {
                        result = ((Customer)obj).ToString();
                    } 
                    else if (obj is Room)
                    {
                        result = ((Room)obj).ToString();
                    }
                    else
                    {
                        result = ((Hotel)obj).ToString();
                    }

                    Console.Out.WriteLine(result);
                }
                catch (EndOfStreamException e)
                {
                    Console.WriteLine("No object left!" + e.Message);
                    break;
                }
                catch (SerializationException)
                {
                    // Console.WriteLine(e.Message);
                    break;
                }
                catch (System.Xml.XmlException)
                {
                    //Console.WriteLine(e.Message);
                    break;
                }
            }

            fileStream.Close();
        }
    }
}
