public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    // Marks the goal as completed and returns the points (always returns points as it can be completed repeatedly)
    public override int MarkComplete()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
        }
        return Points; // Always gives the points each time it is completed
    }

    // Override the GetStringRepresentation method to handle the EternalGoal specifics
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Points},{_isCompleted}";
    }
}
