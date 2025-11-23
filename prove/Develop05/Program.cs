using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Eternal Quest Menu");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Quit");

            Console.Write("Choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ShowGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    Console.Write("Enter filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Enter filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case "7":
                    return;
            }
        }
    }
}