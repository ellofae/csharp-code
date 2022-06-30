using System;

class Program
{
    public struct Distance
    {
        public int feet;
        public float inches;

        public Distance(int f, float i) { feet = f; inches = i; }
    }

    static public float Compare(in Distance d1, in Distance d2)
    {
        float objOne = d1.feet + d1.inches / 12.0f;
        float objTwo = d2.feet + d2.inches / 12.0f;

        if (objOne > objTwo)
            return objOne;
        else if (objOne < objTwo)
            return objTwo;
        else
        {
            Console.WriteLine("equal..");
            return 0.0f;
        }
    }

    public static void Main()
    {
        Distance obj1 = new Distance(5, Convert.ToSingle(6.25));
        Distance obj2 = new Distance(12, Convert.ToSingle(11.5));

        Console.WriteLine(Compare(in obj1, in obj2));
    }
}
