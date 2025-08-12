public abstract class Activity
{
    private DateTime _date;
    private float _duration;
    private string _type;

    public DateTime GetDate
    {
        get { return _date; }
    }
    public float GetDuration
    {
        get { return _duration; }
    }



    public Activity(DateTime date, float duration, string type)
    {
        _date = date;
        _duration = duration;
        _type = type;
    }
    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();
    public string GetActivityType()
    {
        return _type;
    }
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetActivityType()} ({_duration} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}