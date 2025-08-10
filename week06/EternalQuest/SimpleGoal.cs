public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent() // Override to ensure that the goal can only be completed once
    {
        if (!IsComplete())
        {
            base.RecordEvent();
            Console.WriteLine($"Simple goal '{_shortName}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Simple goal '{_shortName}' is already complete.");
        }
    }
}