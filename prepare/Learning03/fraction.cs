using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

     public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

       public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

        public double GetDecimalValue()
    {
          return (double)numerator / denominator;
    }
}