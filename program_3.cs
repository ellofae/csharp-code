using System;

class Program
{
    public static void Main()
    {
        int count = 0;
        int tempValue = 0;

        int numA = 0;
        int numB = 0;
        char mathOperator = ' ';
        string expression;

        Console.Write("\n\nType in an expression(a operator b): ");
        expression = (Console.ReadLine()).Trim() + " ";

        foreach (char letter in expression)
        {
            if (letter == ' ')
            {
                if (count == 0)
                    numA = tempValue;
                else if (count == 2)
                    numB = tempValue;

                count++;
                tempValue = 0;
            }
            else
            {
                if (count == 0 || count == 2)
                    tempValue = tempValue * 10 + (letter - '0');
                else
                    mathOperator = letter;

            }
        }

        switch (mathOperator)
        {
            case '+':
                Console.Write($"{numA} + {numB}: {numA + numB}");
                break;
            case '-':
                Console.Write($"{numA} - {numB}: {numA - numB}");
                break;
            case '*':
                Console.Write($"{numA} * {numB}: {Convert.ToDouble(numA) * Convert.ToDouble(numB) }");
                break;
            case '/':
                Console.Write($"{numA} / {numB}: {Convert.ToDouble(numA) / Convert.ToDouble(numB) }");
                break;
            case '%':
                Console.Write($"{numA} % {numB}: {Convert.ToSingle(numA) / Convert.ToSingle(numB) }");
                break;
            default:
                Console.WriteLine("No such operation found..");
                break;
        }

    }
}
