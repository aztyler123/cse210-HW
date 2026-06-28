using System;
public class Square : Shape
{
    private double _side;
    

    //Make sure to end cap all things are it will grey out and take forever to find the problem.
    public Square(string color, double side) : base(color)
        {
            _side = side; //created the variable and made it easier to use
        }
    

    //set up the get
    public override double GetArea() 
    {
        return _side * _side;
    }
    
}