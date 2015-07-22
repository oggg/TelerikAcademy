using System;

class EvenDifferences
{
    const int EVEN_JUMP = 2;
    const int ODD_JUMP = 1;

    static void Main()
    {
        string consoleInput = Console.ReadLine();
        string[] inputArray = consoleInput.Split(' ');
        long[] digitArray = new long[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            digitArray[i] = long.Parse(inputArray[i]);
        }

        long evenAbsoluteDifference = 0;
        int index = 1;

        while (index < digitArray.Length)
        {
            long difference = CalculateDifference(digitArray[index - 1], digitArray[index]);
            int jump = 0;
            if (difference % 2 == 0)
            {
                jump = EVEN_JUMP;
                evenAbsoluteDifference += difference;
            }
            else
            {
                jump = ODD_JUMP;
            }
            
            index += jump;
        }

        Console.WriteLine(evenAbsoluteDifference);
    }

    static long CalculateDifference(long previous, long next)
    {
        long difference = Math.Abs(next - previous);

        return difference;
    }
}