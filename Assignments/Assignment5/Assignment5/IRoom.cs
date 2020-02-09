using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IRoom
    {
        string RoomNumber { get; }
        double Area { get; }
        string Type { get; }
        double PricePerNight { get; }
        string Description { get; }
    }
}
