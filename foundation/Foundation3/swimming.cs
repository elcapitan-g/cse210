using System;

public class Swimming : Activity
{
    private int _laps; 

    public Swimming(DateTime activityDate, int durationInMinutes, int laps)
        : base(activityDate, durationInMinutes)
    {
        _laps = laps; 
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; 
    }

    public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60;

    public override double GetPace() => DurationInMinutes / GetDistance();
}
