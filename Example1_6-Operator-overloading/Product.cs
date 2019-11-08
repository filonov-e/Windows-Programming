using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Example_16
{
    namespace Shop
    {
        class Product
        {
            int id;
            string name;
            double unitPrice;
            public Product(int id, string name, double unitPrice)
            {
                this.id = id;
                this.name = name;
                this.unitPrice = unitPrice;
            }
            public override string ToString()
            {
                return id + " " + name + " " + unitPrice;
            }
            //Here we define == operator for the class
            public static bool operator ==(Product p1, Product p2)
            {
                if (p1.name.Equals(p2.name) && p1.unitPrice == p2.unitPrice)
                    return true;
                return false;
            }
            //Here we define != operator for the class
            public static bool operator !=(Product p1, Product p2)
            {
                if (!(p1.name.Equals(p2.name) && p1.unitPrice == p2.unitPrice))
                    return true;
                return false;
            }
            public override bool Equals(object obj)
            {
                // If parameter is null return false.
                if (obj == null)
                {
                    return false;
                }
                //If parameter cannot be cast to Point return false.
                Product p = obj as Product;
                if ((System.Object)p == null)
                {
                    return false;
                }
                if (this.id == p.id && this.name == p.name && this.unitPrice == p.unitPrice)
                    return true;
                return false;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            //Here we define < operator for the class
            public static bool operator <(Product p1, Product p2)
            {
                if (p1.unitPrice < p2.unitPrice)
                    return true;
                return false;
            }
            //Here we define > operator for the class
            public static bool operator >(Product p1, Product p2)
            {
                if (p1.unitPrice > p2.unitPrice)
                    return true;
                return false;
            }
            //Here we define + operator for the class
            public static Product operator +(Product p1, Product p2)
            {
                return new Product(p1.id, p1.name, (p1.unitPrice + p2.unitPrice));
            }
            //Here we define ++ operator for the class
            public static Product operator ++(Product p1)
            {
                return new Product(p1.id, p1.name, ++p1.unitPrice);
            }
        }
    }
}