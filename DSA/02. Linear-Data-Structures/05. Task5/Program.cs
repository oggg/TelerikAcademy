namespace Task5
{
    using System;
    using System.Collections.Generic;
    // using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 6, -10, 12, -33, 45, -16 };

            // numbers = numbers.Where(num => num >= 0).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
