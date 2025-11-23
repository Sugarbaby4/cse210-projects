using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        
    }
    public override bool IsComplete() => false; //never completes
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override string GetStatusString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }
    public override string Serialize()
    {
        return $"EternalGoal | {GetName()} | {GetDescription()} | {GetPoints()}";
    }
}