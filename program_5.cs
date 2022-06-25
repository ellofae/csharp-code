using System;

class Program
{
    public static void Main()
    {
        float initialContribution = 0.0f;
        float finalContribution = 0.0f;
        float percentage = 0.0f;
        int amountOfYears = 0;

        Console.Write("Type in desirable amout of money: ");
        finalContribution = Convert.ToSingle(Console.ReadLine());

        Console.Write("\nType in initial contribution to the bank: ");
        initialContribution = Convert.ToSingle(Console.ReadLine());

        Console.Write("Type in persentage: ");
        percentage = Convert.ToSingle(Console.ReadLine());
        
        while (initialContribution < finalContribution)
        {
            initialContribution = initialContribution + (initialContribution * (percentage / 100f));
            amountOfYears++;
            Console.WriteLine(initialContribution);
        }

        Console.WriteLine($"You will have {finalContribution} in: {amountOfYears}");
    }
}
