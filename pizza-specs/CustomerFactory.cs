using System.Collections.Generic;
using pizza;

namespace pizza_specs
{
    public class CustomerFactory
    {
        private readonly Dictionary<string, Customer> _customers = new Dictionary<string, Customer>();

        public CustomerFactory()
        {
            _customers.Add("Peter", new Customer{ Name = "Peter", FavoritePizza = Pizza.Hawaii });
            _customers.Add("Tim", new Customer { Name = "Tim", FavoritePizza = Pizza.Funghi });
        }

        public Customer Get(string customerName)
        {
            return _customers[customerName];
        }
    }
}