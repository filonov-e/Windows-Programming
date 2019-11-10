using System;
namespace Example_14
{
    class MainClass
    {
        static void ModifyNumber(double d)
        {
            d = 3.4567;
        }

        static void ModifyNumberRef(ref double d)
        {
            d = 3.4567;
        }
        static void SetValue(out double a, out int i, out string s)
        {
            a = -1.234;
            i = -2;
            s = "Tervehdys!";
        }
        static void Main(string[] args)
        {
            double d = 1.234;
            Console.WriteLine("d before calling ModifyNumber(): " + d);
            ModifyNumber(d);
            Console.WriteLine("d after calling ModifyNumber(): " + d);
            ModifyNumberRef(ref d);
            Console.WriteLine("d after calling ModifyNumberRef(): " + d);
            //Here we declare a variable without initialization
            double x;
            int j;
            string text;

            //We can pass variable x without initialization becaus of out keyword
            SetValue(out x, out j, out text);
            Console.WriteLine("x, j, text after calling SetValue():");
            Console.Write(x + " " + j + " " + text);
            Console.ReadLine();
        }
    }
}