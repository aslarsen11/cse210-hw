using System;

public class Cycling : Activity
{
    private double _speed;

    // Constructor
    public Cycling(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * _time / 60;
    }
    public override double CalculateSpeed()
    {
       return _speed;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_time} min)- Distance {CalculateDistance()} miles, Speed {_speed} mph, Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }
}