using System;

class Scripture
{
    private Reference _ref;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _ref = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void Display()
    {
        Console.WriteLine(_ref.GetDisplayText());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        
        Console.WriteLine();
    }
    public void hideRamdomWords(int count)
    {
        Random _rand = new Random();

        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return;

        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}