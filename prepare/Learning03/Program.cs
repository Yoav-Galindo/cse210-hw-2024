using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionNoParameters = new Fraction();
        Console.WriteLine(fractionNoParameters.GetFractionString());
        Console.WriteLine(fractionNoParameters.GetDecimalValue());
        
        Fraction fraction1Parameter = new Fraction(5);
        Console.WriteLine(fraction1Parameter.GetFractionString());
        Console.WriteLine(fraction1Parameter.GetDecimalValue());
        

        Fraction fraction2Parameters = new Fraction(3,4);
        Console.WriteLine(fraction2Parameters.GetFractionString());
        Console.WriteLine(fraction2Parameters.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }

}