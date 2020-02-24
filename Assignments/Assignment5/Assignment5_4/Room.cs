using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment5_4
{
    [DataContract]
    public class Room : IRoom
    {
        [DataMember]
        public string RoomNumber { get; set; }
        [DataMember]
        public double Area { get; set; }
        [DataMember]
        public RoomType Type { get; set; }
        [DataMember]
        public double PricePerNight { get; set; }
        [DataMember]
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
    }
}
