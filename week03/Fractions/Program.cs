using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); //Uses the default constructor
        Fraction f2 = new Fraction(); //Uses the default constructor
        Fraction f3 = new Fraction(5); //Uses the first overloaded constructor
        Fraction f4 = new Fraction(3, 4); //Uses the second overloaded constructor
        Fraction f5 = new Fraction(1, 3); //Uses the second overloaded constructor

        int test1 = 2;
        int test2 = 5;

        f1.SetTop(test1);
        f1.SetBottom(test2);

        Console.WriteLine();
        Console.WriteLine("    Fraction Program");
        Console.WriteLine("Testing the GetTop and GetBottom methods:");
        Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        Console.WriteLine();

        Console.WriteLine("Testing the GetFractionString and GetDecimalValue methods:");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Console.WriteLine();
    }
}