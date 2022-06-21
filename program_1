using System;

namespace Excersises
{
    class Program
    {
        static void Main()
        {
            char ch = 'y';
            int value;
            float tempreture;

            do
            {
                Console.Write("\n\nType in 1 to convert Celcious into Farengeigh\nType in 2 to convert Farengeigh into Celcious: ");
                bool succefulConversion = int.TryParse(Console.ReadLine(), out value);
                if (succefulConversion)
                {
                    if (value == 1)
                    {
                        Console.Write("Type in tempreture in Celcious: ");
                        succefulConversion = float.TryParse(Console.ReadLine(), out tempreture);
                        if (succefulConversion)
                            Console.WriteLine($"Tempreture in Farengeigh: {tempreture * 9f / 5f + 32f}");
                        else
                        {
                            Console.WriteLine("Not correct data type passed..");
                            Environment.Exit(0);
                        }
                    }
                    else if (value == 2)
                    {
                        Console.Write("Type in tempreture in Farengeigh: ");
                        succefulConversion = float.TryParse(Console.ReadLine(), out tempreture);
                        if (succefulConversion)
                            Console.WriteLine($"Tempreture in Celcious: {(tempreture - 32f) / 1.8f}");
                        else
                        {
                            Console.WriteLine("Not correct data type passed..");
                            Environment.Exit(0);
                        }
                    }
                }
                else
                    Console.WriteLine("Try to pass a correct data type..");

                Console.Write("To continue, type in 'y': ");
                succefulConversion = char.TryParse(Console.ReadLine(), out ch);

            } while (ch == 'y');
        }
    }
}
