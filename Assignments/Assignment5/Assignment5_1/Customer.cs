using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    [Serializable]
    class Customer : ICustomer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string RoomNumber { get; private set; }
        public string ArrivalDate { get; private set; }
        public int LengthOfStay { get; private set; }

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
    }
}
