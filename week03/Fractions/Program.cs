using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        fraction1.Numerator = 3;
        fraction1.Denominator = 4;

        Console.WriteLine($"Updated Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
    }
}