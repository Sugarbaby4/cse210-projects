using System;

public class Menu
{
    private Journal _journal = new Journal();

    public void Show()
    {
        int _userImput = 0;

        while (_userImput != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------");
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write new Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal to a File");
            Console.WriteLine("4. Load the Journal to a File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose and option (1-5): ");


            string input = Console.ReadLine();
            int.TryParse(input, out _userImput);


            Console.WriteLine("--------------");
            Console.WriteLine("");


            switch (_userImput)
            {
                case 1:
                    _journal.Write();
                    break;
                case 2:
                    _journal.Display();
                    break;
                case 3:
                    _journal.Save();
                    break;
                case 4:
                    _journal.Load();
                    break;
                case 5:
                    Console.WriteLine("Goodbye, See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid option, Please try again.");
                    break;
            }
        }
    }
}