namespace Task1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var dictionary = new Dictionary<double, int>();

            foreach (var num in array)
            {
                if (!dictionary.ContainsKey(num))
                {
                    dictionary.Add(num, 0);
                }
                dictionary[num]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
