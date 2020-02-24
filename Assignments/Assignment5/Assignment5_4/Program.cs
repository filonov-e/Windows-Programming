using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Assignment5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hotelsFilePath = @"./hotels.json";
            string customersFilePath = @"./customers.json";
            string roomsFilePath = @"./rooms.json";

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

            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer customerJsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);
            DataContractJsonSerializer roomJsonSerializer = new DataContractJsonSerializer(typeof(List<Room>), serializingSettings);
            DataContractJsonSerializer hotelJsonSerializer = new DataContractJsonSerializer(typeof(List<Hotel>), serializingSettings);

            FileStream customerFileWriter = new FileStream(customersFilePath, FileMode.Create);
            FileStream roomFileWriter = new FileStream(roomsFilePath, FileMode.Create);
            FileStream hotelFileWriter = new FileStream(hotelsFilePath, FileMode.Create);

            customerJsonSerializer.WriteObject(customerFileWriter, customers);
            roomJsonSerializer.WriteObject(roomFileWriter, rooms);
            hotelJsonSerializer.WriteObject(hotelFileWriter, hotels);

            customerFileWriter.Close();
            roomFileWriter.Close();
            hotelFileWriter.Close();

            StreamReader customerReader = new StreamReader(customersFilePath);
            StreamReader roomReader = new StreamReader(roomsFilePath);
            StreamReader hotelReader = new StreamReader(hotelsFilePath);

            string customerJsonData = customerReader.ReadToEnd();
            string roomJsonData = roomReader.ReadToEnd();
            string hotelJsonData = hotelReader.ReadToEnd();

            customerReader.Close();
            roomReader.Close();
            hotelReader.Close();

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            List<Customer> customerObjects = jsSerializer.Deserialize<List<Customer>>(customerJsonData);
            List<Room> roomObjects = jsSerializer.Deserialize<List<Room>>(roomJsonData);
            List<Hotel> hotelObjects = jsSerializer.Deserialize<List<Hotel>>(hotelJsonData);

            foreach (Customer customer in customerObjects)
            {
                Console.Out.WriteLine(customer);
            }

            foreach (Room room in roomObjects)
            {
                Console.Out.WriteLine(room);
            }

            foreach (Hotel hotel in hotelObjects)
            {
                Console.Out.WriteLine(hotel);
            }
        }
    }
}
