using System;
using System.Collections.Generic;

abstract class Activity
{
    private string _date;
    private int _minutes;


    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    protected int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): \nDistance {GetDistance(): 0.0} miles, \nSpeed {GetSpeed(): 0.0} mph, \nPace {GetPace(): 0.00} min per mile";
    }
    
}