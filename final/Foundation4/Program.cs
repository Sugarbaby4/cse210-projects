using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("05 Jan 2025", 60, 10.0),
            new Cycling("05 Jan 2025", 30, 15.0),
            new Swimming("05 Jan 2025", 20, 15)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("____________________");
            Console.WriteLine();
        }
    }
}