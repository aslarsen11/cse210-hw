using System;

public class Running : Activity
{
    private double _distance;

    // Constructor
    public Running(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / _time) * 60;
    }
    public override double CalculatePace()
    {
        return _time / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_time} min)- Distance {_distance} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}