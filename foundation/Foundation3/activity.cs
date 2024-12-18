using System;

public abstract class Activity
{
    private DateTime _activityDate;
    private int _durationInMinutes;

    public Activity(DateTime activityDate, int durationInMinutes)
    {
        _activityDate = activityDate;
        _durationInMinutes = durationInMinutes;
    }

    public DateTime ActivityDate => _activityDate;
    public int DurationInMinutes => _durationInMinutes;

    public virtual double GetDistance() => 0; 
    public virtual double GetSpeed() => 0;    
    public virtual double GetPace() => 0;     

    public string GetSummary()
    {
        return $"{ActivityDate:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
