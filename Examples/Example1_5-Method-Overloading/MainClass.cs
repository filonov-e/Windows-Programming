using System;
//Here we import Shop.Customers namespace
using Shop.Customers;
namespace Example_15
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Here we call the static function
            Console.WriteLine("Firm name: " + Customer.GetFirmName());
            //Here we declare an arrys of Customer bjects
            Customer[] customers = new Customer[4];
            customers[0] = new Customer();
            customers[1] = new Customer("Charlotta");
            customers[2] = new Customer("Charlie", 100);
            customers[3] = new Customer("Emili", 400, 245.6);
            Console.WriteLine("Customer's bonus with default bonus rate: " + customers[3].CustomerBonus());
            Console.WriteLine("Customer's bonus with new bonus rate: " + customers[3].CustomerBonus(0.1));
            Console.Write("Type customer id: ");
            int id = Int16.Parse(Console.ReadLine());
            bool customerFound = false;
            //In the following we check whether customer with given id is found
            //from the list of customers.
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].CustomerFound(id))
                {
                    customerFound = true;
                    Console.WriteLine("Customer with id " + id + " found: " + customers[i].CustomerFound(id));
                }
            }
            if (!customerFound)
                Console.WriteLine("Customer with id " + id + " was not found!");
            Console.Write("Type customer name: ");
            string name = Console.ReadLine();
            //In the following we check whether customer with given name is found
            //from the list of customers.
            customerFound = false;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].CustomerFound(name))
                {
                    customerFound = true;
                    Console.WriteLine("Customer with name " + name + " found: " + customers[i].CustomerFound(name));
                }
            }
            if (!customerFound)
                Console.WriteLine("Customer with name " + name + " was not found! ");

        }
    }
}