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
        public string Type { get; private set; }
        public double PricePerNight { get; private set; }
        public string Description { get; private set; }

        public Room(
            string roomNumber,
            double area,
            string type,
            double pricePerNight,
            string description
        ) {
            this.RoomNumber = roomNumber;
            this.Area = area;
            this.Type = type;
            this.PricePerNight = pricePerNight;
            this.Description = description;
        }
    }
}
