using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity
{
    private int _duration;

    public ListingActivity(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {
        Console.WriteLine("Listing Activity: List things that you appreciate in your life.");
        string prompt = "Think about the things that you appreciate.";
        Console.WriteLine(prompt);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> itemsListed = new List<string>(); 

        while (DateTime.Now < endTime)
        {
            Console.Write("Add an item: ");
            string item = Console.ReadLine(); 
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemsListed.Add(item);
            }
            ShowSpinner(1); 
        }

        Console.WriteLine("\nThese are the things you have listed:");
        foreach (string listedItem in itemsListed)
        {
            Console.WriteLine($"- {listedItem}");
        }

        Console.WriteLine($"You listed {itemsListed.Count} items.");
        Console.WriteLine(" Remeber to thank the Lord in all things!");
        Console.WriteLine(" You have completed the listing Activity!");

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
