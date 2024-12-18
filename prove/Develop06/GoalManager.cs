using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints;

    public GoalManager()
    {
        totalPoints = 0;
    }

    // Add a new goal to the list
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    // Mark a goal as completed and add its points to the total
    public void MarkGoalComplete(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            totalPoints += goals[goalIndex].MarkComplete();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    // Display the list of goals with their status
    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }

    // Get the current total points
    public int GetTotalPoints()
    {
        return totalPoints;
    }

    // Save goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // Load goals from a file
    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                try
                {
                    Goal goal = Goal.CreateGoal(line);
                    AddGoal(goal);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Skipping invalid goal format: {line}");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
