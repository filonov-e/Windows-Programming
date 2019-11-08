using System;

using System.Collections.Generic;

using System.Text;

class Customer

{

    //These are data members

    string name;

    int id;

    decimal credit;

    public const string firm = "ITC Tech";

    //This is the constructor

    public Customer(string name, int id, decimal credit)

    {

        this.name = name;

        this.id = id;

        this.credit = credit;

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

    //This is an ordinary function

    public bool CustomerFound(decimal credit)

    {

        return (credit == this.credit);

    }

    //This is the overloaded version of CustomerFound()

    public bool CustomerFound(string name)

    {

        return name.Equals(this.name);

    }

}

namespace Example_13

{

    class Program

    {

        static void Main(string[] args)

        {

            string name;

            int id;

            decimal credit;

            //We handle the number format exception through try catch

            //statement

            try

            {

                //Here we call the static function

                Console.WriteLine("Firm name: " + Customer.GetFirmName());

                Console.Write("Please type customer name: ");

                name = Console.ReadLine();

                Console.Write("Please type customer id: ");

                id = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please type customer credit: ");

                credit = decimal.Parse(Console.ReadLine());

                //Here we declare an o bject

                Customer c = new Customer(name, id, credit);

                Console.Write("Please type customer name: ");

                Console.WriteLine("Customer found: " + c.CustomerFound(Console.ReadLine()));

                Console.Write("Please type customer id: ");

                Console.WriteLine("Customer found: " + c.CustomerFound(Convert.ToInt16(Console.ReadLine())));

                Console.Write("Please type customer credit: ");

                Console.WriteLine("Customer found: " + c.CustomerFound(Convert.ToDecimal(Console.ReadLine())));

            }
            catch (FormatException e)

            {

                Console.WriteLine("Invalide data type!");

            }

            Console.ReadLine();

            return;

        }

    }

}