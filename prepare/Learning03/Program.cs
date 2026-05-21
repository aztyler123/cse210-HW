using System;

class Program
{
    static void Main(string[] args)
    {
        //1st example
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        //2nd example
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        //3rd example
        Fraction frac3 = new Fraction(3,4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        //4th example
        Fraction frac4 = new Fraction(1,3);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());


    
    }
}