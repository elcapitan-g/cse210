public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    protected bool _isCompleted;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        _isCompleted = false;
    }

    // Abstract method to mark a goal as complete and return points earned
    public abstract int MarkComplete();

    // Method to get the status of the goal (whether it is completed or not)
    public string GetStatus()
    {
        return $"[{(_isCompleted ? 'X' : ' ')}] {Name}";
    }

    // Virtual method to get the string representation of the goal
    public virtual string GetStringRepresentation()
    {
        return $"Goal:{Name},{Points},{_isCompleted}";
    }

    // Method to create a specific goal based on string representation
    public static Goal CreateGoal(string goalString)
    {
        string[] parts = goalString.Split(',');

        if (parts.Length >= 2)
        {
            string name = parts[0];
            int points = int.Parse(parts[1]);
            bool isCompleted = bool.Parse(parts[2]);

            // Logic to choose which subclass to create could go here (simple example)
            // Here, we're just going to create a SimpleGoal for the sake of example.
            return new SimpleGoal(name, points);  // Change as needed for other goal types
        }
        else
        {
            throw new FormatException("Invalid goal string format.");
        }
    }
}
