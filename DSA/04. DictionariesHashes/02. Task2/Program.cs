namespace Task2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] array = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var dictionary = new Dictionary<string, int>();

            foreach (var item in array)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                }
                dictionary[item]++;
            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
