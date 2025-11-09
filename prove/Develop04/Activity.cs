using System;

public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _description;


    // ------------Common Start Message------------ //
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting the {_name} activity. ");
        Console.WriteLine(_description);
        Console.Write("Enter Duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Spinner(3);
    }
    // ------------Common End Message------------ //
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Spinner(2);
        Console.WriteLine($"You Completed the {_name} activity for {_duration} seconds.");
        Spinner(3);

    }
    // ------------Spinner Animation------------ //
    protected void Spinner(int seconds)
    {
        List<string> symbols = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i = (i + 1) % symbols.Count;
        }
    }
    // -----------Countdown Timer----------- //
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public virtual void Run() { }
}