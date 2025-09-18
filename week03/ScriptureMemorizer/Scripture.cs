using System.Collections.Generic;
public class Scripture
{
    private static readonly Random _random = new Random();
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public int HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count == 0)
        {
            return 0;
        }

        int count = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
        return count;
    }

    public string GetDisplayText()
    {
        string wordsText = "";
        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }
        wordsText = wordsText.Trim();
        return $"{_reference.GetDisplayText()}: {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}