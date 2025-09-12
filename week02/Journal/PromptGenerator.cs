public class PromptGenerator
{
    private List<string> _prompts;
    private List<string> _shuffledPrompts;
    private static readonly Random _random = new Random();
    private int _currentIndex = 0;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        ShufflePrompts();
    }

    private void ShufflePrompts()
    {
        _shuffledPrompts = _prompts.OrderBy(x => _random.Next()).ToList();
        _currentIndex = 0;
    }

    public string GetRandomPrompt()
    {
        if (_currentIndex >= _shuffledPrompts.Count)
        {       
            // Restart cycle with a new shuffle
            ShufflePrompts(); 
        }

        return _shuffledPrompts[_currentIndex++];
    }
}
