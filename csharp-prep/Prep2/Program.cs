using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade precentage? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

// Stretch challenge //

        string sign = "";

        int lastdigit = number % 10;

        if (lastdigit >= 7)
        {
            sign = "+";
        }
        else if (lastdigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (number >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congragulations you passed!!!");
        }
        else
        {
            Console.WriteLine("Sorry you failed. Best of luck next time!");
        }
    }
}