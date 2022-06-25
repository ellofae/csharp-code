using System;

class Program
{
    public static void Main()
    {
        long number = 0;
        string letters;

        while(true)
        {
            Console.Write("Type in a number: ");
            letters = Console.ReadLine();

            bool succefulConversion = long.TryParse(letters, out number);
            if (succefulConversion)
                Console.WriteLine($"Number: {number}");
            else
            {
                Console.WriteLine("Not convertiable string..");
                Environment.Exit(0);
            }
        }
    }
}
