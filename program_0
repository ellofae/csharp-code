using System;

namespace Excersises
{
    class Program
    {
        static void Main()
        {
            char ch = 'y';

            do
            {
                Console.Write("Type in a number: ");
                long value = 0;
                bool succesfulConversion = long.TryParse(Console.ReadLine(), out value);

                if (succesfulConversion)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("");
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write(value);
                            value = value + 7;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not convertiable value passed..");
                    Environment.Exit(0);
                }

                succesfulConversion = false;
                while(!succesfulConversion)
                {
                    Console.Write("\n\nContinue? if so, type in 'y': ");
                    succesfulConversion = char.TryParse(Console.ReadLine(), out ch);
                }
            } while (ch == 'y');
        }
    }
}
