using System;

class Program
{

    static void Main()
    {
        const int NUMER_OF_BITS_TO_SEARCH_FOR = 5;
        const int NUMER_OF_BITS_TO_SEARCH_IN = 29;

        int patternToSearch = int.Parse(Console.ReadLine());
        int numbers = int.Parse(Console.ReadLine());
        int allOccurences = 0;
        string binaryPattern = ConvertToBin(NUMER_OF_BITS_TO_SEARCH_FOR, patternToSearch);
        
        for (int i = 0; i < numbers; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string inputToBinary = ConvertToBin(NUMER_OF_BITS_TO_SEARCH_IN, inputNumber);

            allOccurences += NumberOfOccurances(binaryPattern, inputToBinary);
        }
        Console.WriteLine(allOccurences);
    }

    static string ConvertToBin(int numberOfBits, int numberToConvert)
    {
        string binaryNumber = Convert.ToString(numberToConvert, 2);
        
        if (binaryNumber.Length < numberOfBits)
        {
            binaryNumber = binaryNumber.PadLeft(numberOfBits, '0');
        }
        return binaryNumber;
    }

    static int NumberOfOccurances(string searchPattern, string convertedInput)
    {
        int countOccurences = 0;
        int occuranceIndex = convertedInput.IndexOf(searchPattern, 0);

        while (occuranceIndex > -1)
        {
            countOccurences++;
            occuranceIndex = convertedInput.IndexOf(searchPattern, occuranceIndex + 1);
        }

        return countOccurences;
    }
}