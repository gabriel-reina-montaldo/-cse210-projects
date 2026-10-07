using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit.");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                0);

                activity.Run();
            }

            else if (choice == "2")
            {
                List<string> prompts = new List<string>();
                prompts.Add("Think of a time when you stood up for someone else.");
                prompts.Add("Think of a time when you did something really difficult.");
                prompts.Add("Think of a time when you helped someone in need.");
                prompts.Add("Think of a time when you did something truly selfless.");

                List<string> questions = new List<string>();
                questions.Add("Why was this experience meaningful to you?");
                questions.Add("Have you ever done anything like this before?");
                questions.Add("How did you get started?");
                questions.Add("How did you feel when it was complete?");
                questions.Add("What made this time different than other times when you were not as successful?");
                questions.Add("What is your favorite thing about this experience?");
                questions.Add("What could you learn from this experience that applies to other situations?");
                questions.Add("What did you learn about yourself through this experience?");
                questions.Add("How can you keep this experience in mind in the future?");

                ReflectingActivity activity = new ReflectingActivity("Reflecting Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                0,
                prompts,
                questions);

                activity.Run();
            }

            else if (choice == "3")
            {
                List<string> prompts = new List<string>();
                prompts.Add("Who are people that you appreciate?");
                prompts.Add("What are personal strengths of yours?");
                prompts.Add("Who are people that you have helped this week?");
                prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");

                ListingActivity activity = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                0,
                0,
                prompts);

                activity.Run();
            }
        }
    }
}