using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;  //set up sepcifications for two sides of a rectangle to solve for area
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}