using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete = false)
        : base(name, description, points)
    {
        _isComplete = complete;
    }
    public override bool IsComplete() => _isComplete;
    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override string GetStatusString()
    {
        string box = _isComplete ? "[x]" : "[ ]";
        return $"{box} {GetName()} ({GetDescription()})";
    }
    public override string Serialize()
    {
        return $"SimpleGoal | {GetName()} | {GetDescription()} | {GetPoints()} | {_isComplete}";
    }
}