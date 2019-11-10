using System;
using System.Collections.Generic;
using System.Collections;
namespace HashtableDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable codes = new Hashtable();
            codes.Add(1, "Canada");
            codes.Add(49, "Germany");
            codes.Add(55, "Brazil");
            codes.Add(98, "Iran");
            codes.Add(358, "Finland");
            Console.WriteLine("The content of the Hashtable:");
            foreach (DictionaryEntry code in codes)
            {
                Console.WriteLine(code.Key + "   -   " + code.Value);
            }
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Canada");
            dictionary.Add(49, "Germany");
            dictionary.Add(55, "Brazil");
            dictionary.Add(98, "Iran");
            dictionary.Add(358, "Finland");
            Console.WriteLine("The content of the Dictionary:");
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine(pair.Key + "   -   " + pair.Value);
            }
        }
    }
}