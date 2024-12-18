public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    // Marks the goal as completed and returns the points
    public override int MarkComplete()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return Points;
        }
        return 0; // No points if it's already completed
    }

    // Override the GetStringRepresentation method to handle the SimpleGoal specifics
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Points},{_isCompleted}";
    }
}
