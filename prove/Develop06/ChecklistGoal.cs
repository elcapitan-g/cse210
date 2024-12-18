public class ChecklistGoal : Goal
{
    public int Target { get; set; }  // The number of times the goal must be completed
    public int BonusPoints { get; set; }  // Bonus points awarded when the target is met
    private int _completionCount;

    public ChecklistGoal(string name, int points, int target, int bonusPoints) : base(name, points)
    {
        Target = target;
        BonusPoints = bonusPoints;
        _completionCount = 0;
    }

    // Marks the goal as completed for this time, increments the completion count, and returns points
    public override int MarkComplete()
    {
        if (_completionCount < Target)
        {
            _completionCount++;
            int earnedPoints = Points;

            // If the goal has been completed the required number of times, add bonus points
            if (_completionCount == Target)
            {
                earnedPoints += BonusPoints;
            }

            return earnedPoints;
        }

        return 0; // No points if the target has already been reached
    }

    // Override the GetStringRepresentation method to handle the ChecklistGoal specifics
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{_isCompleted},{_completionCount}/{Target},{BonusPoints}";
    }
}
