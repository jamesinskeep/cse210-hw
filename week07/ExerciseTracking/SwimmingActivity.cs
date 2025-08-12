public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, float duration, int laps) : base(date, duration, type: "Swimming")
    {
        _laps = laps;
    }
        public override float GetDistance()
    {
        return _laps * 50 / 1609.34f; // Assuming each lap is 50 meters, convert to miles
    }
    public override float GetSpeed()
    {
        return GetDistance() / (GetDuration / 60f); // Speed in mph
    }
    public override float GetPace()
    {
        return GetDuration / GetDistance(); // Pace in minutes per mile
    }
}
