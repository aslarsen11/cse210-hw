using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int time, double laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _time) * 60;
    }
    public override double CalculatePace()
    {
        return _time / CalculateDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_time} min)- Distance {Math.Round(CalculateDistance(), 2)} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph, Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }
}