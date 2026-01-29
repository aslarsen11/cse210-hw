using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public void SetAddress(string address, string city, string stateProvince, string country)
    {
        // Store the address
        _streetAddress = address;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Returns whether the address is in the USA or not
    public bool IsInUSA()
    {
        bool isInUSA;

        if (_country != "USA")
        {
            isInUSA = false;
        }

        else
        {
            isInUSA = true;
        }

        return isInUSA;
    }

    // Returns all of the address' fields together in one string
    public string GetFullAddress()
    {
        return _streetAddress +"\n"+ _city +", "+ _stateProvince +", "+ _country;
    }
}