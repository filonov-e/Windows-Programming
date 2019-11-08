using System;
using System.Collections;
using System.Collections.Generic;
//Here we define shape namespace
namespace Example_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we define the Hashtable obect and initialize it
            Hashtable countryCodes = new Hashtable();
            countryCodes.Add("358", "Finland");
            countryCodes.Add("1", "Canada");
            countryCodes.Add("254", "Kenya");

            //Here we print the full content of the Hashtable
            foreach (string code in countryCodes.Keys)
                Console.WriteLine(code + " --> " + countryCodes[code]);
            //Here we print all values in the Hastable
            Console.WriteLine("Values in the hash table: ");
            foreach (string value in countryCodes.Values)
                Console.WriteLine(value);

            SortedList countryAbbr = new SortedList();
            countryAbbr.Add("FI", "Finland");
            countryAbbr.Add("NL", "Netherlands");
            countryAbbr.Add("IR", "Iran");
            countryAbbr.Add("CA", "Canada");
            Console.WriteLine("Country with abbreviation NL in sorted list: " + countryAbbr["NL"]);
            Console.WriteLine("Third value in the sorted list: " + countryAbbr.GetByIndex(2));
            //Here we print the full content of the SortedList
            Console.WriteLine("The contnet of the sorted list: ");
            foreach (string abbr in countryAbbr.Keys)
                Console.WriteLine(abbr + " --> " + countryAbbr[abbr]);

            //Here we print all values in the Hastable
            Console.WriteLine("Values in the SortedList: ");
            foreach (string abbr in countryAbbr.Values)
                Console.WriteLine(abbr);
            //Here we print the full content of the SortedList
            Console.WriteLine("The contnet of the sorted list: ");
            foreach (string abbr in countryAbbr.Keys)
                Console.WriteLine(abbr + " --> " + countryAbbr[abbr]);
            //Here we define a generic sorted list
            Console.WriteLine("Values in the generic SortedList: ");
            SortedList<string, string> countryAbbrGeneric = new SortedList<string, string>();
            countryAbbrGeneric.Add("FI", "Finland");
            countryAbbrGeneric.Add("NL", "Netherlands");
            countryAbbrGeneric.Add("IR", "Iran");
            countryAbbrGeneric.Add("CA", "Canada");
            Console.WriteLine("Country with abbreviation NL in sorted list: " + countryAbbr["NL"]);
            Console.WriteLine("Third value in the sorted list: " + countryAbbr.GetByIndex(2));
        }
    }
}