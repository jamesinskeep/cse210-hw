using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Checklist goal '{_shortName}' updated. Completed: {_amountCompleted}/{_target}, Bonus: {_bonus} points.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Checklist goal '{_shortName}' completed! Total: {_amountCompleted}/{_target}. You earned an additional {_bonus} points.");
                _isComplete = true; // Mark as complete when target is reached
            }
        }
        else
        {
            _amountCompleted++;
            Console.WriteLine($"Checklist goal '{_shortName}' completed! Total: {_amountCompleted}/{_target}.");
        }       
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_amountCompleted},{_target},{_bonus}";
    }

    public override string GetPoints()
    {
        if (_target == _amountCompleted)
        {
            return (int.Parse(_points) + _bonus).ToString();
        }
        else
            return _points;
    }
}