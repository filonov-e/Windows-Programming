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
    [XmlRoot("room")]
    public class Room : IRoom
    {
        [XmlElement("roomNumber")]
        public string RoomNumber { get; set; }
        [XmlElement("area")]
        public double Area { get; set; }
        [XmlElement("type")]
        public RoomType Type { get; set; }
        [XmlElement("pricePerNight")]
        public double PricePerNight { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }

        public Room() { }

        public Room(
            string roomNumber,
            double area,
            RoomType type,
            double pricePerNight,
            string description
        ) {
            this.RoomNumber = roomNumber;
            this.Area = area;
            this.Type = type;
            this.PricePerNight = pricePerNight;
            this.Description = description;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Room number: " + this.RoomNumber);
            sb.AppendLine("Area: " + this.Area.ToString());
            sb.AppendLine("Type: " + this.Type.ToString());
            sb.AppendLine("Price per night: " + this.PricePerNight.ToString());
            sb.AppendLine("Description: " + this.Description);

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
