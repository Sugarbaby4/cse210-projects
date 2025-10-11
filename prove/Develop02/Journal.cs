using System;
using System.Collections.Generic;
using System.IO;
// list<entry> //
// Display(): void, Save(): void, Load(): void, Write(); void //
public class Journal
{
    // Attribute //
    public List<Entries> _listEntry = new List<Entries>();


    // Behaviors //
    public void Write()
    {
        Entries entry = new Entries();
        entry._date = DateTime.Now.ToShortDateString();
        entry.GeneratePrompt();

        Console.WriteLine(entry._givenPrompts);
        Console.Write("Entry: ");
        entry._userEntry = Console.ReadLine();

        _listEntry.Add(entry);

        Console.Write("Entry saved in Memory");
    }
    public void Display()
    {
        if (_listEntry.Count == 0)
        {
            Console.Write("No entries to display.");
            return;
        }
        foreach (Entries entry in _listEntry)
        {
            entry.Display();
        }
    }
    public void Save()
    {
        Console.Write("Enter a file name to save to (ex: journal.txt): ");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entries entry in _listEntry)
            {
                outputFile.WriteLine($"{entry._date}|{entry._givenPrompts}|{entry._userEntry}");
            }
        }
        Console.WriteLine($"Journal saved successfully to '{_fileName}'!");
    }
    public void Load()
    {
        Console.Write("Enter a file name to load from: ");
        string _fileName = Console.ReadLine();

        if (!File.Exists(_fileName))
        {
            Console.WriteLine("File not found. Please check the name and try again.");
            return;
        }

        string[] lines = File.ReadAllLines(_fileName);
        _listEntry.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');


            if (parts.Length == 3)
            {
                Entries entry = new Entries();
                entry._date = parts[0];
                entry._givenPrompts = parts[1];
                entry._userEntry = parts[2];
                _listEntry.Add(entry);
            }
        }

        Console.WriteLine($"Journal Loaded Succssefully from '{_fileName}'!");

    }
}