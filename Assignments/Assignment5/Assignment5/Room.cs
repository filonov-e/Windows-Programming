using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Room : IRoom
    {
        public string RoomNumber { get; private set; }
        public double Area { get; private set; }
        public RoomType Type { get; private set; }
        public double PricePerNight { get; private set; }
        public string Description { get; private set; }

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
