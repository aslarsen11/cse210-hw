using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color) // Constructor
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}