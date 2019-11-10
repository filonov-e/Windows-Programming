using System;
using System.Collections;

namespace Example_17
{
    class Customer
    {
        //These are data members
        string name;
        int id;

        public const string firm = "ITC Tech";

        //This is the constructor
        public Customer()
        {
            this.name = "customer not known";
            this.id = 0;
        }

        public Customer(string name)
        {
            this.name = name;
            this.id = 0;
        }

        public Customer(int id)
        {
            this.name = "Customer not known";
            this.id = id;
        }

        public Customer(string name, int id)
        {

            this.name = name;

            this.id = id;

        }

        //This is a static function member
        public static string GetFirmName()
        {

            return firm;

        }

        //This is an ordinary function
        public bool CustomerFound(int id)
        {

            return (id == this.id);

        }

        //This is the overloaded version of CustomerFound()
        public bool CustomerFound(string name)
        {

            return name.Equals(this.name);

        }

        public string CustomerInfo()
        {

            return name + " " + id;

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            //Here we call the static function
            Console.WriteLine("Firm name: " + Customer.GetFirmName());
            Console.WriteLine("------------------------");

            //In the following we declare an arry list for keeping Customer
            //bjects and initialize it.
            ArrayList customers = new ArrayList();
            customers.Add(new Customer());
            customers.Add(new Customer("Charlie", 100));
            customers.Add(new Customer("Charlotta"));
            customers.Add(new Customer("Victor", 200));
            customers.Add(new Customer("Valentine", 300));

            Console.Write("Type customer id: ");
            int id = Int16.Parse(Console.ReadLine());

            bool customerFound = false;

            //In the following we check whether customer with given id is found
            //from the list of customers.
            for (int i = 0; i < customers.Count; i++)
            {
                //Here we access Customer objects from the ArrayList. Notice
                //that we should do type casting in order to convert data type object
                //to Customer.
                if (((Customer)customers[i]).CustomerFound(id))
                {
                    customerFound = true;
                    Console.WriteLine("Customer info: " + ((Customer)customers[i]).CustomerInfo());
                }
            }

            if (!customerFound)
                Console.WriteLine("Customer with id " + id + " was not found!");

            Console.Write("Type customer name: ");
            string name = Console.ReadLine();

            //In the following we check whether customer with given name is found
            //from the list of customers.
            customerFound = false;
            for (int i = 0; i < customers.Count; i++)
            {
                if (((Customer)customers[i]).CustomerFound(name))
                {
                    customerFound = true;
                    Console.WriteLine("Customer info: " + ((Customer)customers[i]).CustomerInfo());
                }

            }

            if (!customerFound)
                Console.WriteLine("Customer with name " + name + " was not found! ");

            return;
        }
    }
}