using System;


class CalculationProblem
{
    const int NUNBER_BASE = 23;

    static void Main()
    {
        char[] numbersRelation = new char[23];

        for (int i = 0; i < numbersRelation.Length; i++)
        {
            numbersRelation[i] = (Char)(Convert.ToUInt16('a') + i);
        }

        string consoleInput = Console.ReadLine();
        string[] inputArr = consoleInput.Split(' ');
        long convertionResult = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            convertionResult += ConvertWord(inputArr[i], numbersRelation);
        }

        string backwardConversion = BackwardConversion(convertionResult, numbersRelation);

        Console.WriteLine("{0} = {1}", backwardConversion, convertionResult);
    }

    static long Power(int number)
    {
        long result = 1;
        for (int i = 0; i < number; i++)
        {
            result *= NUNBER_BASE;
        }

        return result;
    }

    static long ConvertWord(string inputToConvert, char[] relation)
    {
        long result = 0;
        for (int i = inputToConvert.Length - 1; i >= 0; i--)
        {
            char currentSymbol = inputToConvert[i];
            int currentNumber = Array.IndexOf(relation, currentSymbol);
            result += currentNumber * Power(inputToConvert.Length - 1 - i);
        }
        return result;
    }

    static string BackwardConversion(long number, char[] relation)
    {
        string intermediateResult = string.Empty;

        while (number > 0)
        {
            intermediateResult += relation[(number % NUNBER_BASE)];
            number /= NUNBER_BASE;
        }

        char[] conversionArray = intermediateResult.ToCharArray();
        Array.Reverse(conversionArray);
        string backwardResult = new String(conversionArray);
        return backwardResult;
    }
}