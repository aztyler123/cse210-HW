using System;

public class Circle : Shape
{
    private double _radius;

    //set up everything like the others except for using pi to calculate.

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}