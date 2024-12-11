using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("E como mai to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity below:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit Program");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                new BreathingActivity(duration).Start();
            }
            else if (choice == "2")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                new ReflectionActivity(duration).Start();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                new ListingActivity(duration).Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Mahalo for using the Mindfulness Program. A hui hou!");
                keepRunning = false; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.ReadLine(); 
            }
        }
    }
}
