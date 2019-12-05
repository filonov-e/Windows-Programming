using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Concert
    {
        public string Title { get; private set; }
        public string Location { get; private set; }
        public string Date { get; private set; }
        public string Time { get; private set; }
        public double Price { get; private set; }

        public Concert(
            string Title,
            string Location,
            string Date,
            string Time,
            double Price
        )
        {
            this.Title = Title;
            this.Location = Location;
            this.Date = Date;
            this.Time = Time;
            this.Price = Price;
        }

        public Concert(Concert c)
        {
            Title = c.Title;
            Location = c.Location;
            Date = c.Date;
            Time = c.Time;
            Price = c.Price;
        }

        public static bool operator <(Concert c1, Concert c2)
        {
            return c1.Price < c2.Price;
        }

        public static bool operator >(Concert c1, Concert c2)
        {
            return c1.Price > c2.Price;
        }

        public static Concert operator ++(Concert c)
        {
            c.Price += 5;
            return c;
        }

        public static Concert operator --(Concert c)
        {
            c.Price -= 5;
            return c;
        }

        public Concert Clone()
        {
            return new Concert(
                Title,
                Location,
                Date,
                Time,
                Price
            );
        }

        public override string ToString()
        {
            string[] strings = {
                Title,
                Location,
                Date,
                Time,
                Price.ToString()
            };

            int maxLength = strings.OrderByDescending(s => s.Length).First().Length;

            StringBuilder info = new StringBuilder();
            info.Append(string.Format("{0,15} {1," + maxLength + ":N2}\n", "Title:", strings[0]));
            info.Append(string.Format("{0,15} {1," + maxLength + ":N2}\n", "Location:", strings[1]));
            info.Append(string.Format("{0,15} {1," + maxLength + ":N2}\n", "Date:", strings[2]));
            info.Append(string.Format("{0,15} {1," + maxLength + ":N2}\n", "Time:", strings[3]));
            info.Append(string.Format("{0,15} {1," + maxLength + ":N2}\n", "Price:", strings[4]));
            return info.ToString();
        }
    }
}
