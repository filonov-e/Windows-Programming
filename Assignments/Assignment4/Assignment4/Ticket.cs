using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Ticket
    {
        public string TicketId { get; private set; }
        public string PassengerId { get; private set; }

        public Flight Flight { get; private set; }

        public float Price { get; private set; }

        public readonly float ExtraTax;

        public Ticket(
            string ticketId,
            string passengerId,
            Flight flight,
            float price)
        {
            TicketId = ticketId;
            PassengerId = passengerId;
            Flight = flight;
            Price = price;
            ExtraTax = Flight.IsOnWeekends() ? 
                Constants.TaxForWeekends
                :
                Constants.TaxForWeekdays;
        }

        public float GetPrice()
        {
            return Price * (1.0f + ExtraTax);
        }

        public string GetTicketAndPassengerInfo(List<Passenger> passengers)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GetTicketInfo());

            Passenger correctPassenger = passengers.Find(passenger => (
                passenger.Id == PassengerId
            ));

            sb.AppendLine(correctPassenger.GetInfo());

            return sb.ToString();
        }

        public string GetTicketInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("tikcet id: " + TicketId);
            sb.AppendLine("passenger id: " + PassengerId);
            sb.AppendLine("\nflight info ------------------------\n");
            sb.AppendLine(Flight.GetFlightInfo());
            sb.AppendLine("end flight info --------------------\n");
            sb.AppendLine("base price: " + string.Format("{0:N2}", Price));
            sb.AppendLine("tax (%): " + string.Format("{0:N2}", ExtraTax * 100));
            sb.AppendLine("total price: " + string.Format("{0:N2}", GetPrice()));

            return sb.ToString();
        }
    }
}
