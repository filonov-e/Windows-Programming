using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_1
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string flightId { get; set; }

        public Customer() { }

        public Customer(string id, string name, string flightId)
        {
            this.id = id;
            this.name = name;
            this.flightId = flightId;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + id);
            sb.AppendLine("Name: " + name);
            sb.AppendLine("Flight ID: " + flightId);

            return sb.ToString();
        }
    }
}
