using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment5_3
{
    [XmlRoot("hotel")]
    public class Hotel : IHotel
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("constructionDate")]
        public string ConstructionDate { get; set; }
        [XmlElement("address")]
        public string Address { get; set; }
        [XmlElement("numberOfStars")]
        public int NumberOfStars { get; set; }
        [XmlElement("rooms")]
        public List<Room> Rooms { get; set; } = new List<Room>();
        [XmlElement("customers")]
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Hotel() { }

        public Hotel(string name, string constructionDate, string address, int numberOfStars)
        {
            this.Name = name;
            this.ConstructionDate = constructionDate;
            this.Address = address;
            this.NumberOfStars = numberOfStars;
        }

        public Hotel(string name, string constructionDate, string address, int numberOfStars, List<Room> rooms, List<Customer> customers)
        {
            this.Name = name;
            this.ConstructionDate = constructionDate;
            this.Address = address;
            this.NumberOfStars = numberOfStars;
            this.Rooms = new List<Room>(rooms);
            this.Customers = new List<Customer>(customers);
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Construction date: " + this.ConstructionDate);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Number of stars: " + this.NumberOfStars);
            sb.AppendLine("Rooms: {");
            foreach (Room room in this.Rooms) {
                sb.AppendLine("-------------------------------");
                sb.Append(room.ToString());
                sb.AppendLine("-------------------------------");
            }
            sb.AppendLine("}");
            sb.AppendLine("Customers: {");
            foreach (Customer customer in this.Customers)
            {
                sb.AppendLine("-------------------------------");
                sb.Append(customer.ToString());
                sb.AppendLine("-------------------------------");
            }
            sb.AppendLine("}");
            
            return sb.ToString();
        }

        public static string WriteXML<T>(T type, string filePathName)
        {
            if (type == null)
                return "Invalid data type!";
            XmlSerializer serializer = new XmlSerializer(type.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(
                filePathName,
                new XmlWriterSettings()
                {
                    OmitXmlDeclaration = true,
                    ConformanceLevel = ConformanceLevel.Auto,
                    Indent = true
                }
            );
            serializer.Serialize(xmlWriter, type);
            xmlWriter.Close();
            return "File length: " + new FileInfo(filePathName).Length;
        }

        public static T ReadXML<T>(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}
