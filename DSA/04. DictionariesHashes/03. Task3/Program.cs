namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string path = "../../../words.txt";
            char[] symbols = { ' ', '.', '!', '?', ',' };
            string[] content = File.ReadAllText(path).ToLower().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            foreach (var item in content)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                }
                dictionary[item]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
