using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class TextAnalyzer
    {
        public string Text { get; private set; }
        private readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public TextAnalyzer(out string s)
        {
            Init(out s);
            Text = s;
        }

        private void Init(out string initStr)
        {
            Random random = new Random();
            initStr = new string(Enumerable.Repeat(chars, 50).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public SortedList<char, int> Process(string text)
        {
            SortedList<char, int> charList = new SortedList<char, int>();
            foreach (char c in text)
            {
                if (!charList.ContainsKey(c))
                {
                    charList.Add(c, text.Count(item => item == c));
                }
            }

            return charList;
        }
    }
}
