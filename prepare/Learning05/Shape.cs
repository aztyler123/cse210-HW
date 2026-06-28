using System;
using System.Collections.Generic;

public abstract class Shape 
{
    private string _color; //set up color
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color) //set up setter
    {
        _color = color;
    }

    public abstract double GetArea(); 
}
