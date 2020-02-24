using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3
{
    public enum RoomType
    {
        Single,
        Double,
        Studio
    }

    interface IRoom
    {
        string RoomNumber { get; }
        double Area { get; }
        RoomType Type { get; }
        double PricePerNight { get; }
        string Description { get; }
    }
}
