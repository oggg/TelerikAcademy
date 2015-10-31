namespace Task3
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer numbers: ");
            List<int> numbers = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }

                int number = int.Parse(input);
                numbers.Add(number);
            }

            Console.WriteLine("Numbers entered: {0}", string.Join(", ", numbers));

            numbers.Sort();
            Console.WriteLine("Numbers sorted: {0}", string.Join(", ", numbers));
        }
    }
}
