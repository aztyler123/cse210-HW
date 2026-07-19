using System;
using System.Collections.Generic;

namespace Ordermenu
{
    public class Customer
    {
        private string _name;
        private Address _address; //helps keep track of the address and addresses.

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }
        public string Name {get => _name; set => _name = value; } //be careful how you order the arrows and the actual set up or it will break your code
        public Address Address { get => _address; set => _address = value; }

        public bool LivesInUsa()
        {
            return _address.IsInUsa();
        }
    }
}