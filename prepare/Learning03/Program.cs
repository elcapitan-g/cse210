using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Console.WriteLine("Default Fraction: " + defaultFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + defaultFraction.GetDecimalValue());

        Fraction singleNumeratorFraction = new Fraction(5);
        Console.WriteLine("Single Numerator Fraction: " + singleNumeratorFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + singleNumeratorFraction.GetDecimalValue());

        Fraction simpleFraction = new Fraction(3, 4);
        Console.WriteLine("Simple Fraction: " + simpleFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + simpleFraction.GetDecimalValue());

        Fraction repeatingDecimalFraction = new Fraction(1, 3);
        Console.WriteLine("Repeating Decimal Fraction: " + repeatingDecimalFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + repeatingDecimalFraction.GetDecimalValue());
    }
}