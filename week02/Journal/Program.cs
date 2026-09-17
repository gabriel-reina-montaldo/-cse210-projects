using System;
using System.Security.Cryptography;

// Added an option in which you can clear all the entries.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear all");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._promptText = prompt;
                anEntry._entryText = response;
                anEntry._date = date;

                theJournal.AddEntry(anEntry);
            }

            else if (choice == "2")
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the file name?");
                string file = Console.ReadLine();

                theJournal.LoadFromFile(file);
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the file name?");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Are you sure you want to clear all entries? (Yes/No)");
                string response = Console.ReadLine();
                response = response.ToLower();

                if (response == "Yes")
                {
                    theJournal.ClearAll();
                }
            }
        }
    }
}