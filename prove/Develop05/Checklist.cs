using System;
using System.ComponentModel;

public class CheckList : Goal
{
    private int _timesCompleted;

    private int _targetCount;

    private int _bonusPoints;


    public CheckList(string name, string description, int points, int target, int bonus, int completed = 0) 
        : base(name, description, points)
    {
        _timesCompleted = completed;
        _targetCount = target;
        _bonusPoints = bonus;
    }
    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }
    public override int RecordEvent()
    {
        _timesCompleted++;
        int total = GetPoints();

        if (_timesCompleted == _targetCount)
        {
            total += _bonusPoints;
        }

        return total;
    }
    public override string GetStatusString()
    {
        string box = IsComplete() ? "x" : " ";
        return $"{box} {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount}";
    }
    public override string Serialize()
    {
        return $"ChecklistGoal | {GetName()} | {GetDescription()} | {GetPoints()} | {_targetCount} | {_bonusPoints} | {_timesCompleted}";
    }
}