public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

   
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public int HideRandomWords(int numberToHide)
    {
        return 0;
    }

    public string GetDisplayText()
    {
        foreach (Word word in _words)
        {
            string verseText = word.GetDisplayText();
        }
        return $"{_reference.GetDisplayText()}: {word}";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}