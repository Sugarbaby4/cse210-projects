using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }
    public override void Run()
    {
        DisplayStartingMessage();

        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown(4); 
            Console.Write("Breathe out...");
            Countdown(6);
            Console.WriteLine();
        }

        DisplayEndMessage();   
    }
}