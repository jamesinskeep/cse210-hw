public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(DateTime date, float duration, float distance)
        : base(date, duration, type: "Running")
    {
        _distance = distance;
    }
        public override float GetDistance()
    {
        return _distance; ;
    }
    public override float GetSpeed()
    {
        return (_distance / GetDuration) * 60; // Speed in mph
    }
    public override float GetPace()
    {
        return GetDuration / _distance; // Pace in minutes per mile
    }
}