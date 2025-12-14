using System;

class Reception : Event
{
    private string _rsvpEmail;


    public Reception(string title, string decription, string date, string time, Address address, string rsvpEmail):
                base(title, decription, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Reception \nRSVP Email: {_rsvpEmail}";
    }
    public override string GetShortDetails()
    {
        return $"Reception: {DateTime.Now.ToShortDateString()}";
    }
}