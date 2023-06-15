using System;

public class Circle: Shape
{
    private double _radius; 

    public Circle(string color, double radius): base (color)
    {
        _color = color;
        _radius = radius;
    }
    public override double GetArea()
    {
        return (double)_radius * double.Pi * double.Pi;
    }
}