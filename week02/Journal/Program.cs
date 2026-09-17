using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
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

            }

            else if (choice == "4")
            {

            }
        }
        
        
    }
}