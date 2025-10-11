using System;
// prompts, date, userEntry, name //
// prompts(); void //
public class Entries
{
    // Attributs //
    public string _givenPrompts;

    public string _date;    

    public string _userEntry;


    public void GeneratePrompt()
    {
        Prompts promptGenorator = new Prompts();
        _givenPrompts = promptGenorator.getRandomPrompt();
    }
    public void Display()
    {
        Console.WriteLine("================");
        Console.WriteLine($"{_date} -- {_givenPrompts} ");
        Console.WriteLine($"Entry: {_userEntry}");
        Console.WriteLine("----------------");
        Console.WriteLine("");
    }
}