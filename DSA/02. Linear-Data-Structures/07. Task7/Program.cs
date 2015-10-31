namespace Task7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var dictionary = new Dictionary<int, int>();

            foreach (var num in array)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num]++;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            var keys = dictionary.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                Console.WriteLine("{0} -> {1} times", key, dictionary[key]);
            }
        }
    }
}
