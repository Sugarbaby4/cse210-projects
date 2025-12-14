using System;

class OutdoorGathering : Event
{
    private string _weatherForcast;


    public OutdoorGathering(string title, string decription, string date, string time, Address address, string weatherForcast):
                base(title, decription, date, time, address)
    {
        _weatherForcast = weatherForcast;
    }
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\ntype: Outdoor Gathering \nWeather Forcast: {_weatherForcast}";
    }
    public override string GetShortDetails()
    {
        return $"Outdoor Gathering on {DateTime.Now.ToShortDateString()}";
    }
}