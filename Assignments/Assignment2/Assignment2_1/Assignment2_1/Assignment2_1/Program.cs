using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Concert myConcert1 = new Concert("Some titile1", "Vaasa", "10.10.2020", "15:00", 14.99);
            Concert myConcert2 = new Concert("Some titile2", "Helsinki", "11.10.2020", "16:00", 149.99);
            Concert myConcert3 = new Concert("Some titile3", "Moscow", "12.10.2020", "17:00", 12.9);
            Concert myConcert4 = new Concert("Some titile4", "Tokyo", "13.10.2020", "18:00", 1.98);
            Concert myConcert5 = new Concert("Some titile5", "Bali", "14.10.2020", "19:00", 1400.0);
            Hashtable concerts = new Hashtable()
            {
                { myConcert1.Title, myConcert1.ToString() },
                { myConcert2.Title, myConcert2.ToString() },
                { myConcert3.Title, myConcert3.ToString() },
                { myConcert4.Title, myConcert4.ToString() },
                { myConcert5.Title, myConcert5.ToString() },
            };
            foreach (DictionaryEntry concertItem in concerts)
            {
                Console.WriteLine(concertItem.Value);
            }
            Console.WriteLine("myConcert1 > myConcert2 is " + (myConcert1 > myConcert2));
            Console.WriteLine("myConcert2 < myConcert3 is " + (myConcert2 < myConcert3));
            myConcert3++;
            Console.WriteLine("myConcert3++ is:\n" + myConcert3);
        }
    }
}
