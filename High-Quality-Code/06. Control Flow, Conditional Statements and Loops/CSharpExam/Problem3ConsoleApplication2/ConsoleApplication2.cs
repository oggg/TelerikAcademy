using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int line = 0, i = 0;
        BigInteger currentMultiplication = 1;
        BigInteger before10Multiplications = 1;
        BigInteger totalMultiplications = 1;

        do
        {
            string input = Console.ReadLine();
            if (input == "END")
                break;

            if (line % 2 == 0)
            {
                currentMultiplication = 1;
                for (i = 0; i < input.Length; i++)
                {
                    char current = input[i];
                    if (current != '0')
                    {
                        currentMultiplication *= current - '0';
                    }
                }
                totalMultiplications *= (ulong)currentMultiplication;
            }

            line++;
            if (line < 10)
            {
                before10Multiplications = totalMultiplications;
            }
            else if (line == 10)
            {
                totalMultiplications = 1;
            }
                
        } while (true);

        Console.WriteLine(before10Multiplications);
        if (line > 10)
        {
            Console.WriteLine(totalMultiplications);
        }
    }
}