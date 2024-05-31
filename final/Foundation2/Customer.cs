using System;
using System.Diagnostics.Contracts;

public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsInUS()
        {
            if (_address.IsAddressInUS() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCustomerDetails()
        {
            return $"{_name} \n{_address.GetAddress()}";
        }
    
    }