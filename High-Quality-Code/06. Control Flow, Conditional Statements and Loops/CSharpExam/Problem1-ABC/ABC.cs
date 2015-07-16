using System;

class ABC
{
    const float NUMBER_OF_DIGITS = 3.0f;

    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int maxNumber = Math.Max(A, Math.Max(B, C));
        int minNumber = Math.Min(A, Math.Min(B, C));
        float averageNumber = CalculateAverage(A, B, C);
        Console.WriteLine(maxNumber);
        Console.WriteLine(minNumber);
        Console.WriteLine("{0:F3}", averageNumber);
    }

    static float CalculateAverage(int firstDigit, int secondDigit, int thirdDigit)
    {
        float result = (firstDigit + secondDigit + thirdDigit) / NUMBER_OF_DIGITS;
        return result;
    }
}
