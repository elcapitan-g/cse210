using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            Random random = new Random();

            while (true)
            {
                PrintMenu();
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        string prompt = GetRandomPrompt(random);
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        string date = GetCurrentDate();

                        var entry = new JournalEntry(prompt, response, date);
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry added successfully!");
                        break;

                    case 2:
                        journal.DisplayEntries();
                        break;

                    case 3:
                        Console.Write("Enter the filename to save the journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;

                    case 4:
                        Console.Write("Enter the filename to load the journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
        }

        static string GetRandomPrompt(Random random)
        {
            string[] prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "Have I done any good today?",
                "Did I think to pray?",
                "Did I help someone in need?",
            };

            int index = random.Next(prompts.Length);
            return prompts[index];
        }

        static string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
