using System;

using System.Globalization;

namespace Predicate.Entities
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
 
        public Products(string name, double price)
        {
            Name = name;
            Price = price;

        }

        public override string ToString()
        {
            return "Nome: "
                    + Name
                    + ", "
                    + Price.ToString("C", new CultureInfo("pt-BR"));
        }

    }

}
