using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void ShowScore()
    {
        Console.WriteLine($"Your total score is: {_score}");
    }
    public void ShowGoals()
    {
        Console.WriteLine($"Your Goals: ");
        int index = 1; 

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetStatusString()}");
            index++;
        }
        Console.WriteLine();
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter Points: ");
        int points = int.Parse(Console.ReadLine());


        switch (choice)
        {
            case "1":
                AddGoal(new SimpleGoal(name, desc, points));
            break;

            case "2":
                AddGoal(new EternalGoal(name, desc, points));
            break;

            case "3":
                Console.Write("Enter Target Completions:");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                AddGoal(new CheckList(name, desc, points, target, bonus));
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you acomplish? ");
        ShowGoals();
        Console.Write("Enter Goal Number: ");
        int index = int.Parse(Console.ReadLine()) - 1 ;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"{earned} points awarded! ");
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.Serialize());
            }
        }
        Console.WriteLine("Goals Saved! ");
    }
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File not found. Please check filename and try again. ");
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                AddGoal(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "Checklist")
            {
                AddGoal(new CheckList(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
        Console.WriteLine("Goals Loaded!");
    } 
}