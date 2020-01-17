using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Flight
    {
        public string Id { get; private set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public string Date { get; private set; }

        public Flight(
            string id, 
            string origin, 
            string destination,
            string date)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
        }

        public void SetOrigin(string origin)
        {
            Origin = origin;
        }

        public void SetDestination(string destination)
        {
            Destination = destination;
        }

        public void SetDate(string date)
        {
            Date = date;
        }

        public string GetFlightInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + Id);
            sb.AppendLine("Origin: " + Origin);
            sb.AppendLine("Destination: " + Destination);
            sb.AppendLine("Date: " + Date);
            
            return sb.ToString();
        }

        public bool IsOnWeekends()
        {
            DateTime date = Convert.ToDateTime(Date);
            return (
                date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday
            );
        }
    }
}
