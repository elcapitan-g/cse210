using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize GoalManager
        GoalManager goalManager = new GoalManager();

        // Create and add goals to the GoalManager
        goalManager.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend the Temple", 50, 10, 500));

        // Display all goals and their status
        Console.WriteLine("Goals List:");
        goalManager.DisplayGoals();

        // Simulate marking some goals as complete
        Console.WriteLine("\nMarking goals as complete...");
        goalManager.MarkGoalComplete(0); // Run a Marathon (marks as complete)
        goalManager.MarkGoalComplete(1); // Read Scriptures (each time, earns points)
        goalManager.MarkGoalComplete(2); // Attend the Temple (first time)

        // Display updated goals and total points
        Console.WriteLine("\nUpdated Goals List:");
        goalManager.DisplayGoals();
        Console.WriteLine($"Total Points: {goalManager.GetTotalPoints()}");

        // Save goals to a file
        string filename = "goals.txt";
        goalManager.SaveGoals(filename);
        Console.WriteLine($"\nGoals have been saved to {filename}.");

        // Load goals from the file
        Console.WriteLine("\nLoading goals from file...");
        GoalManager newGoalManager = new GoalManager();
        newGoalManager.LoadGoals(filename);
        newGoalManager.DisplayGoals();
    }
}
