using System;
using System.Collections.Generic;

namespace Ordermenu
{
    public class Address
    {
        private string _streetAddress;
        private string _city;

        private string _stateProvince;
        private string _country;


        //constructors under variables
        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city; 
            _stateProvince = stateProvince;
            _country = country;
        }


        //time for the getters and setters user and code movement
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; } 
        public string City { get => _city; set => _city = value; }
        public string StateProvince { get => _stateProvince; set => _stateProvince = value; }
        public string Country { get => _country; set => _country = value; }

        public bool IsInUsa()
        {
            return _country.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFullAddressString()
        {
            return ($"{_streetAddress} {_city}, {_stateProvince} {_country}");
        }
    }

}