public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(DateTime date, float duration, float speed) : base(date, duration, type: "Cycling")
    {
        _speed = speed;
    }
        public override float GetDistance()
    {
        return _speed * (GetDuration / 60); // Distance in miles
    }
    public override float GetSpeed()
    {
        return _speed; 
    }
    public override float GetPace()
    { 
        return 60 / _speed; // Pace in minutes per mile
    }
}