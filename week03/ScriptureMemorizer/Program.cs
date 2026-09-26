// Added an option so the user can choose how many words to hide in each round.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether", 12, 27);
        string text = "I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me;";
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.Write("How many words would you like to hide? ");
            int numberToHide = int.Parse(Console.ReadLine());
            scripture.HideRandomWords(numberToHide);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}