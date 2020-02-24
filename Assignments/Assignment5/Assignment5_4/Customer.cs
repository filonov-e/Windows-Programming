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
    public class Customer : ICustomer
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string RoomNumber { get; set; }
        [DataMember]
        public string ArrivalDate { get; set; }
        [DataMember]
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
    }
}
