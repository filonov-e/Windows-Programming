using System;
//Here we import Example_16.Shop namespace
using Example_16.Shop;
namespace Example_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(100, "Milk", 1.19);
            Product p2 = p1;
            Product p3 = new Product(300, "Bread", 2.45);
            Product p4 = new Product(400, "Bread", 2.45);
            //Here we print the information of original p1 and p2
            Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);
            Console.WriteLine("p3: " + p3);
            Console.WriteLine("p4: " + p4);

            Console.WriteLine("p1==p2? : " + (p1 == p2));
            Console.WriteLine("p1.Equals(p2): " + p1.Equals(p2));
            Console.WriteLine("p3==p4? : " + (p3 == p4));
            Console.WriteLine("p3.Equals(p4): " + p3.Equals(p4));

            Console.WriteLine("p3.Equals(p1): " + p3.Equals(p1));

            //Here we increment p1
            p1++;
            Console.WriteLine("p1 after incrementation : " + p1);
            Console.WriteLine("p1<p2? : " + (p1 < p2));
            Console.WriteLine("p1+p2 : " + (p1 + p2));
        }
    }
}