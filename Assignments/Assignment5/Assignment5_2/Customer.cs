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
    [XmlRoot("customer")]
    public class Customer : ICustomer
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("address")]
        public string Address { get; set; }
        [XmlElement("roomNumber")]
        public string RoomNumber { get; set; }
        [XmlElement("arrivalDate")]
        public string ArrivalDate { get; set; }
        [XmlElement("lengthOfStay")]
        public int LengthOfStay { get; set; }

        public Customer() { }

        public Customer(string name, string address, string roomNumber, string arrivalDate, int lengthOfStay)
        {
            this.Name = name;
            this.Address = address;
            this.RoomNumber = roomNumber;
            this.ArrivalDate = arrivalDate;
            this.LengthOfStay = lengthOfStay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("RoomNumber: " + this.RoomNumber);
            sb.AppendLine("ArrivalDate: " + this.ArrivalDate);
            sb.AppendLine("LengthOfStay: " + this.LengthOfStay.ToString());

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
