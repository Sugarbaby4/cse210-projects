using System;

class Program
{
    public static void Main(string[] args)
    {
        List<(Reference, string)> scriptureLibrary = new List<(Reference, string)>
        {
            (new Reference("Matthew", 5, 44, 45),
                "But I say unto you, Love your enemies, bless them that curse you, do good unto them that hate you, and pray for them which despitfully use you, and persecute you; That ye may be the children of your father which is in heaven: for he maketh his son to rise on the evil and on the goo, and sendeth rain on the just and on the unjust."),
            (new Reference("John", 17, 3),
                "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent."),
            (new Reference("Ephesians", 1, 10),
                "That in the dispensation of the fullness of times he might gather together in one all things in Christ, both which are in heaven, and which are on earth; even in him."),
            (new Reference("Matthew", 22, 37, 39),
                "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind.  This is the first and great commandment.  And the second is like unto it, Thou shalt love thy neighbor as thyself.")
        };


        Random _rand = new Random();
        int index = _rand.Next(scriptureLibrary.Count);
        Reference refPicked = scriptureLibrary[index].Item1;
        string textPicked = scriptureLibrary[index].Item2;

        Scripture scripture = new Scripture(refPicked, textPicked);


        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Congradulations you've memorized the entier scripture!");
                break;
            }

            Console.WriteLine("Press enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.hideRamdomWords(3);
        }
    }
}