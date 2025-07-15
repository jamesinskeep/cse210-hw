using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.GetFractionString();
        fraction.GetDecimalValue();

        Fraction fraction1 = new Fraction(5);
        fraction1.GetFractionString();
        fraction1.GetDecimalValue();

        Fraction fraction2 = new Fraction(3, 4);
        fraction2.GetFractionString();
        fraction2.GetDecimalValue();

        Fraction fraction3 = new Fraction(1, 3);
        fraction3.GetFractionString();
        fraction3.GetDecimalValue();

    }
}