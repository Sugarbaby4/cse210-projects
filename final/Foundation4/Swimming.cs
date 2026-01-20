using System;

class Swimming : Activity
{
    private int _laps;


    public Swimming(string date, int minutes, int laps):
                base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62; //miles
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 70;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}