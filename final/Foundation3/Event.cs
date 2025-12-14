using System;

class Event
{
    private string _title;
    private string _decription;
    private string _date;
    private string _time;
    private Address _address;


    public Event(string title, string decription, string date, string time, Address address)
    {
        _title = title;
        _decription = decription;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"{_title}\n{_decription} \nDate: {_date} \nTime: {_time} \nAddress: {_address.GetFullAddress()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public virtual string GetShortDetails()
    {
        return $"Event: {_title} on {_date}";
    }
}