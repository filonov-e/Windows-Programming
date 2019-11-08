namespace Shop
{
    namespace Customers
    {
        class Customer
        {
            //These are data members
            private string name;
            private int id;
            private double shoppingAmount;
            private const string firm = "ITC Tech";
            //This is the constructor
            public Customer()
            {
                this.name = "customer not known";
            }
            public Customer(string name)
            {
                this.name = name;
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
            public Customer(string name, int id, double shoppingAmount)
            {
                this.name = name;
                this.id = id;
                this.shoppingAmount = shoppingAmount;
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
            public double CustomerBonus(double bonusRate = 0.05)
            {
                return shoppingAmount * bonusRate;
            }
        }
    }
}