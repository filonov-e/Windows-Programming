using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    delegate string FlightDelegate(Flight flight);
    class FlightActions
    {
        public static string GetInfo(Flight myFlight)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("From: ");
            sb.Append(myFlight.GetOrigin() + '\n');
            sb.Append("To: ");
            sb.Append(myFlight.GetDestination());

            return sb.ToString();
        }
    }
}
