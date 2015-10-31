namespace Task1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter positive numbers. To break, enter blank line: ");

            ICollection<int> sequence = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }

                int number = int.Parse(input);
                sequence.Add(number);
            }

            int sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
            }

            Console.WriteLine("SUm: {0}, average: {1}", sum, (double)sum / sequence.Count);
        }
    }
}
