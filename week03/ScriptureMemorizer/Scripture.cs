using System.Collections.Generic;
public class Scripture
{
    private static readonly Random _random = new Random();
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public int HideRandomWords(int numberToHide)
    {
        var visibleWords = _words
            .Where(w => !w.IsHidden()).ToList();

        if (!visibleWords.Any())
            return 0;

        int count = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            //Removes it from visibleWords ensuring it wont select the same word twice.
            visibleWords.RemoveAt(index);
        }
        return count;
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}