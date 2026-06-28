using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Now we need to create the list and then put each class in that list.

        List<Shape> shapes = new List<Shape>();


        shapes.Add(new Square("Red", 4.0));
        shapes.Add(new Rectangle("Blue", 5.0, 3.0));
        shapes.Add(new Circle("Green", 2.5)); //use a capital Add

        //use a loop for the display and call.
        foreach (Shape shape in shapes)
        {
            //pull the color
            string color = shape.GetColor();
            //pull the area
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}." );
        }
    }
}