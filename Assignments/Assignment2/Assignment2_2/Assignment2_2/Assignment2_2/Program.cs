using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            TextAnalyzer analyzer = new TextAnalyzer(out s);
            Console.WriteLine(s);
            SortedList<char, int> list = analyzer.Process(s);
            foreach (char c in list.Keys)
            {
                Console.WriteLine(c + " : " + list[c]);
            }
        }
    }
}
