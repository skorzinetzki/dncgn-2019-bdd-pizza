using System.Collections.Generic;
using pizza;

namespace pizza_specs
{
    public class AddressFactory
    {
        private readonly Dictionary<string,Address> _addresses = new Dictionary<string, Address>();

        public AddressFactory()
        {
            _addresses.Add("work", new Address
            {
                Label = "work",
                City = "Köln",
                ZipCode = "50829",
                Street = "Butzweilerhof-Allee 2"
            });

            _addresses.Add("home", new Address
            {
                Label = "home",
                City = "Köln",
                ZipCode = "50823",
                Street = "Gutenbergstr. 24"
            });
        }

        public Address Get(string addressLabel)
        {
            return _addresses[addressLabel];
        }
    }
}