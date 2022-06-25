using System;

class Program
{
    public static void Main()
    {
        float initialContribution = 0.0f;
        float percentage = 0.0f;
        int amountOfYears = 0;

        Console.Write("Type in initial contribution to the bank: ");
        initialContribution = Convert.ToSingle(Console.ReadLine());

        Console.Write("Type in amount of years: ");
        amountOfYears = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type in persentage: ");
        percentage = Convert.ToSingle(Console.ReadLine());

        for(int i = 0; i < amountOfYears; i++)
        {
            initialContribution = initialContribution + (initialContribution * (percentage / 100f));
        }

        Console.WriteLine($"In {amountOfYears} years you will have: {initialContribution} dollars");
    }
}
