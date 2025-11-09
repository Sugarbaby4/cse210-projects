using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _entries;
    private Random _rand = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _entries = new List<string>();
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nYou have 5 seconds to think before you start...");
        Countdown(5);

        Console.WriteLine("Start listing items (press Enter after each):");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    _entries.Add(entry);
            }
        }

        Console.WriteLine($"\nYou listed {_entries.Count} items!");
        DisplayEndMessage();
    }
}