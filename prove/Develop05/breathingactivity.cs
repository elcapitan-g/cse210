using System;
using System.Threading;

public class BreathingActivity
{
    private int _duration;

    public BreathingActivity(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Breathing Activity: Focus on your breathing.");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly.");
        Console.WriteLine("You will be asked to breathe in and out.");
        Console.WriteLine("Get ready...");

        ShowSpinner(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4); 

            Console.WriteLine("Breathe out...");
            ShowSpinner(4); 
        }

        TimeSpan durationCompleted = DateTime.Now - startTime;

        Console.WriteLine("\nBreathing Activity complete!");
        Console.WriteLine($"You completed the activity for {durationCompleted.TotalSeconds} seconds.");
        Console.WriteLine("Good job! Keep up the great work!");

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
                Thread.Sleep(500);  

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
            Console.WriteLine("Mahalo nui for participating! A hui hou.");
            Environment.Exit(0);  
        }
        else
        {
            Console.WriteLine("Invalid option, please enter 1 to return to the menu or 2 to quit.");
            ReturnToMenuOrQuit();
        }
    }
}
