using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_4
{
    interface IHotel
    {
        string Name { get; }
        string ConstructionDate { get; }
        string Address { get; }
        int NumberOfStars { get; }
        List<Room> Rooms { get; }
        List<Customer> Customers { get; }
        void AddRoom(Room room);
        void AddCustomer(Customer customer);
    }
}
