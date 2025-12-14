using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public Lecture(string title, string decription, string date, string time, Address address, string speaker, int capacity)
                :base(title, decription, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Lecture \nSpeaker: {_speaker} \nCapacity {_capacity}";
    }
    public override string GetShortDetails()
    {
        return $"Lecture: {_speaker} on {DateTime.Now.ToShortDateString()}";
    }
}