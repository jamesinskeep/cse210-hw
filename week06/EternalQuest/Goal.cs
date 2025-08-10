using System.Runtime.InteropServices.Marshalling;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_shortName}' completed! Description: {_description}, Points: {_points}");
        Console.WriteLine($"Total points earned: {_points}");
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        if (IsComplete())
            return $"[X] {_shortName} ({_description})";
        else
            return $"[ ] {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{_shortName},{_description},{_points},{_isComplete}";
    }

    public virtual string GetPoints()
    {
        return _points;
    }
}