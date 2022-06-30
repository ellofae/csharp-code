using System;

class Program
{

    public struct Fraction
    {
        public int upperPart;
        public int lowerPart;

        public Fraction(int x, int y) { upperPart = x; lowerPart = y; }
        public readonly void Display() { Console.WriteLine($"{upperPart}/{lowerPart}"); }
    }

    public static Fraction fadd(in Fraction f1, in Fraction f2)
    {
        Fraction temp = new Fraction();
        temp.upperPart = f1.upperPart * f2.lowerPart + f2.upperPart * f1.lowerPart;
        temp.lowerPart = f1.lowerPart * f2.lowerPart;

        return temp;
    }
    public static Fraction fsub(in Fraction f1, in Fraction f2)
    {
        Fraction temp = new Fraction();
        temp.upperPart = f1.upperPart * f2.lowerPart - f2.upperPart * f1.lowerPart;
        temp.lowerPart = f1.lowerPart * f2.lowerPart;

        return temp;
    }
    public static Fraction fmul(in Fraction f1, in Fraction f2)
    {
        Fraction temp = new Fraction();
        temp.upperPart = f1.upperPart * f2.upperPart;
        temp.lowerPart = f1.lowerPart * f2.lowerPart;

        return temp;
    }
    public static Fraction fdiv(in Fraction f1, in Fraction f2)
    {
        Fraction temp = new Fraction();
        temp.upperPart = f1.upperPart * f2.lowerPart;
        temp.lowerPart = f1.lowerPart * f2.upperPart;

        return temp;
    }

    public static void Main()
    {
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(5, 4);
        Fraction result = new Fraction();

        result = fadd(f1, f2);
        result.Display();

        result = fsub(f1, f2);
        result.Display();

        result = fmul(f1, f2);
        result.Display();

        result = fdiv(f1, f2);
        result.Display();
    }
}
