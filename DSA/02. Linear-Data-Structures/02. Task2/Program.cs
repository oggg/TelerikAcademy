namespace Task2
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static int DigitsCount = 3;

        static void Main()
        {
            Console.WriteLine("Enter {0} ints", DigitsCount);
            IList<int> numbers = new List<int>();

            for (int i = 0; i < DigitsCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine("Numbers entered: {0}", string.Join(", ", numbers));
            Console.WriteLine("Numbers entered: {0}", string.Join(", ", DigitReverser(numbers)));
        }

        private static IList<int> DigitReverser(IList<int> collection)
        {
            Stack<int> reverseHelper = new Stack<int>();

            foreach (var item in collection)
            {
                reverseHelper.Push(item);
            }

            for (int i = 0; i < DigitsCount; i++)
            {
                collection[i] = reverseHelper.Pop();
            }

            return collection;
        }
    }
}
