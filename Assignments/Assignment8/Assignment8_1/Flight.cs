using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_1
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string company { get; set; }

        [DataMember]
        public string origin { get; set; }

        [DataMember]
        public string destination { get; set; }

        [DataMember]
        public string date { get; set; }

        public Flight() { }

        public Flight(string id, string company, string origin, string destination, string date)
        {
            this.id = id;
            this.company = company;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + id);
            sb.AppendLine("Company: " + company);
            sb.AppendLine("Origin: " + origin);
            sb.AppendLine("Destination: " + destination);
            sb.AppendLine("Date: " + date);
            return sb.ToString();
        }
    }
}
