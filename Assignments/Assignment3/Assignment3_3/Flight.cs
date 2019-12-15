using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    class Flight
    {
        private string Id, Origin, Destination, Date;
        private double Price;

        public Flight(string Id, string Origin, string Destination, string Date, double Price)
        {
            this.Id = Id;
            this.Origin = Origin;
            this.Destination = Destination;
            this.Date = Date;
            this.Price = Price;
        }

        public string GetFlightInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + Id);
            sb.AppendLine("Origin: " + Origin);
            sb.AppendLine("Destination: " + Destination);
            sb.AppendLine("Date: " + Date);
            sb.AppendLine("Price: " + string.Format("{0:N2}", Price));

            return sb.ToString();
        }

        public string GetId()
        {
            return Id;
        }

        public string GetOrigin()
        {
            return Origin;
        }

        public string GetDestination()
        {
            return Destination;
        }

        public string GetDate()
        {
            return Date;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
