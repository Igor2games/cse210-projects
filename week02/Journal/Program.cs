using System;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";
        //Add Journal
        Journal theJournal = new Journal();

        while (menu != "5")
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                //Add entry and prompts
                Entry anEntry = new Entry();
                PromptGenerator randomPrompt = new PromptGenerator();
                string prompt = randomPrompt.GetRandomPrompt();

                //Entry date
                DateTime theCurrentTime = DateTime.Now;
                string datetext = theCurrentTime.ToShortDateString();
                anEntry._date = datetext;

                //Generate random prompt
                Console.WriteLine(prompt);
                anEntry._promptText = prompt;
                Console.Write(">");
                string text = Console.ReadLine();
                anEntry._entryText = text;

                //Add to Journal
                theJournal.AddEntry(anEntry);

            }

            if (menu == "2")
            {
                theJournal.DisplayAll();
            }

            if (menu == "3")
            {
                Console.WriteLine("Whats the filename?");
                theJournal.LoadFromFile(Console.ReadLine());
            }

            if (menu == "4")
            {
                Console.WriteLine("Whats the filename?");
                theJournal.SaveToFile(Console.ReadLine());
            }
        }

        Console.WriteLine("Thanks for using the program.");
    }
}