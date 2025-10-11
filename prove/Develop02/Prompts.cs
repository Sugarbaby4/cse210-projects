using System;

public class Prompts
{
    private List<string> _promptEntries = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "What did someone do that impacted the rest of my day?",
        "What did I do that was new or different today?",
    };

    public string getRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptEntries.Count);
        return _promptEntries[randomIndex];
    }
}