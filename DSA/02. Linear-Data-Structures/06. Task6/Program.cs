namespace Task6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var groups = numbers.GroupBy(num => num);

            foreach (var group in groups)
            {
                if (group.Count() % 2 != 0)
                {
                    while (numbers.Contains(group.Key))
                    {
                        numbers.Remove(group.Key);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
