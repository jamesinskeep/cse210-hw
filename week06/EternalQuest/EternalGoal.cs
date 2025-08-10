public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}";
    }

    public override void RecordEvent()
    {
        // override record event so that iscomplete is not set to true.
        Console.WriteLine($"Eternal goal '{_shortName}' event recorded. Description: {_description}, Points: {_points}");
        Console.WriteLine($"Total points earned: {_points}");
    }
}