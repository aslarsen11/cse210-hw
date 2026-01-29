using System;

public abstract class Activity
{
    protected string _date;
    protected int _time;

    public Activity(string date, int time) // Constructor
    {
        _date = date;
        _time = time;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public int GetLength()
    {
        return _time;
    }

    public void SetLength(int time)
    {
        _time = time;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary();
}