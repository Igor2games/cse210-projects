using System;
using System.Net.Quic;
// Added "visibleWords.RemoveAt(index);" to Scripture class to ensure it doenst choose the same word twice.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press Enter to continue or type 'quit' to finish\n");
        Console.WriteLine(scripture.GetDisplayText());
        string quit = Console.ReadLine();

        while (!scripture.IsCompletelyHidden() || quit != "quit")
        {
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);
            if (key.Key != ConsoleKey.Enter)

                break;

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            quit = Console.ReadLine();
        }
        Console.WriteLine("\nDone!");
    }
}