using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Hotel
    {
        public string Name { get; private set; }
        public string ConstructionDate { get; private set; }
        public string Address { get; private set; }
        public int NumberOfStars { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<Customer> Customers { get; private set; }
    }
}
