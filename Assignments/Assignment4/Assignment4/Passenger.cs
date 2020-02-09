using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Passenger
    {
        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public List<Ticket> Tickets = new List<Ticket>();

        virtual public Ticket this[int index]
        {
            set
            {
                Tickets.Insert(index, value);
            }

            get
            {
                return Tickets[index];
            }
        }

        public Passenger(
            string id,
            string firstName,
            string lastName,
            string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public void SetId(string id)
        {
            Id = id;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public virtual string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("id: " + Id);
            sb.AppendLine("firstName: " + FirstName);
            sb.AppendLine("lastName: " + LastName);
            sb.AppendLine("phoneNumber: " + PhoneNumber);
            if (Tickets != null && Tickets.Count() > 0)
            {
                sb.AppendLine("\ntickets info ------------------\n");
                foreach (Ticket t in Tickets)
                {
                    sb.AppendLine(t.GetTicketInfo());
                }
                sb.AppendLine("end tickets info --------------");
            }

            return sb.ToString();
        }
    }
}
