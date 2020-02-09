using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Customer : ICustomer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string RoomNumber { get; private set; }
        public string ArrivalDate { get; private set; }
        public int LengthOfStay { get; private set; }
    }
}
