using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Exceptions_Homework;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        List<T> result = new List<T>();

        if (arr == null)
        {
            throw new ArgumentNullException("A collection should be provided");
        }
        if (startIndex < 0)
        {
            throw new IndexOutOfRangeException("Start index should be a positive number");
        }
        if (count < 1)
        {
            throw new ArgumentException("Count should be bigger tham zero");
        }
        if (startIndex + count > arr.Length - 1)
        {
            throw new ArgumentOutOfRangeException("The collection is shorter");
        }
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        Debug.Assert(result.Count == count, "Resulting collection is not equal to required length");
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            return "Invalid count!";
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("Number {0} is not prime", number);
                return;
            }
        }
        Console.WriteLine("Number {0} is prime", number);
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        int primeNumber = 37;
        CheckPrime(37);
        int notPrime = 49;
        CheckPrime(notPrime);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = Calculator.AverageExamResultInPercents(peter);
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
