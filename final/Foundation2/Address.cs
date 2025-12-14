using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvence;
    private string _country;


    public Address(string street, string city, string stateOrProvence, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvence = stateOrProvence;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    public override string ToString()
    {
        return $"{_street}\n{_city}, {_stateOrProvence}\n{_country}";
    }
}