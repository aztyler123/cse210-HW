using System;

public class Fraction
{
    private int _top;
    private int _bottom;


   //specifying the range
    public Fraction() : this(1,1)
    {
    }

    public Fraction(int top) : this(top, 1)
    {
    }

    public Fraction(int top, int bottom){
        if(bottom == 0)
        {
            Console.WriteLine("That value is undefined. ");
            bottom = 1; //handles the error for if a o is put in and it goes through locking the denominator.
        }
        _top = top; //top numerator value
        _bottom = bottom; //bottom denominator value
        Reduce();
    }
    
    public void SetBottom(int bottom)
    {
        if(bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
        
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string fraction = ($"{_top}/{_bottom}"); //this sets up the format for the fraction
        return fraction;
    }

    public double GetDecimalValue() //get rid of error if you match the double with the other double
    {
         return (double)_top/ (double)_bottom; //floating point created so that the division will give us the decimals. 
    }
    private void Reduce()
    {
        int a = Math.Abs(_top);
        int b = Math.Abs(_bottom);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        int gcd = a;

        if (gcd > 0)
        {
            _top /= gcd;
            _bottom /= gcd;
        }
    }
}