using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions, List<string> usedPrompts, List<string> usedQuestions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _usedPrompts = usedPrompts;
        _usedQuestions = usedQuestions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(7);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        List<string> availablePrompts = new List<string>();

        foreach (string prompt in _prompts)
        {
            if (!_usedPrompts.Contains(prompt))
            {
                availablePrompts.Add(prompt);
            }
        }

        if (availablePrompts.Count == 0)
        {
            _usedPrompts.Clear();
            availablePrompts = new List<string>(_prompts);
        }

        int index = random.Next(availablePrompts.Count);
        string selectedPrompt = availablePrompts[index];

        _usedPrompts.Add(selectedPrompt);

        return selectedPrompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();

        List<string> availableQuestions = new List<string>();

        foreach (string question in _questions)
        {
            if (!_usedQuestions.Contains(question))
            {
                availableQuestions.Add(question);
            }
        }

        if (availableQuestions.Count == 0)
        {
            _usedQuestions.Clear();
            availableQuestions = new List<string>(_questions);
        }

        int index = random.Next(availableQuestions.Count);
        string selectedQuestion = availableQuestions[index];

        _usedQuestions.Add(selectedQuestion);

        return selectedQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"---{prompt}---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();

        Console.WriteLine();
        Console.Write($"> {question} ");
    }
}