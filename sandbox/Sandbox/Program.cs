using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // capitalize
        string randomWords = "hello sandbox world!";
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalize = textInfo.ToTitleCase(randomWords);
        Console.WriteLine(capitalize);
    }
}

// python: .upper()  C#: .ToUpper()
// python: .capitalize  C#: using System.Globalization; 
// new sandbox: cd sandbox, dotnet new console -o Playground --use-program-main, cd test, dotnet build, cd Playground, dotnet run