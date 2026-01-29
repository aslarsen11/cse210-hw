using System;

public class Customer
{
    private string _customerName;
    private Address _address = new Address();

    public string GetAddress()
    {
        // Go second through the Address.cs file
        return _customerName + "\n" + _address.GetFullAddress();
    }

    public void SetCustomerInfo(string name, string address, string city, string stateProvince, string country)
    {
        // Store the customer name, then forward the rest of the information on to Address
        _customerName = name;
        _address.SetAddress(address, city, stateProvince, country);
    }

    public bool IsInUSA()
    {
        // Go second through the Address.cs file
        return _address.IsInUSA();
    }
}