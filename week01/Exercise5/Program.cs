using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        string userName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int userNumber = PromptUserNumber();

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        int squareNumber = SquareNumber(userNumber);

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}.");
        }

        DisplayResult(userName, squareNumber);
    }
}