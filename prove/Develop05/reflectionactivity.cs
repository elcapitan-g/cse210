using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity
{
    private int _duration;

    public ReflectionActivity(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {

        Console.WriteLine("Reflection Activity: Reflect on a meaningful experience.");
        string prompt = "Think of a time when you showed strength or overcame a challenge.";
        Console.WriteLine(prompt);

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",

        };

        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4); 
        }

        Console.WriteLine("\nRemember this. The Lord will help guide you in all things..");

        Console.WriteLine("You have completed the Reflection Activity!");

        ReturnToMenuOrQuit();
    }

    private void ShowSpinner(int seconds)
    {
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        string spinner = @"|/-\";

        while (DateTime.Now < futureTime)
        {
            foreach (char c in spinner)
            {
                Console.Write(c);
                Thread.Sleep(200);  
                Console.Write("\b \b");  
            }
        }
    }

    private void ReturnToMenuOrQuit()
    {
        Console.WriteLine("\nWould you like to return to the main menu or quit?");
        Console.WriteLine("1. Return to Menu");
        Console.WriteLine("2. Quit");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Returning to the main menu...\n");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Mahalo nui for participating! A hui hou!");
            Environment.Exit(0);  
        }
        else
        {
            Console.WriteLine("Invalid option, please enter 1 to return to the menu or 2 to quit.");
            ReturnToMenuOrQuit();
        }
    }
}
