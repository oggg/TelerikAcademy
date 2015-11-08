namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        private const string FileName = @"../../students.txt";
        static void Main()
        {
            string[] fileContent = File.ReadAllLines(FileName);
            var collection = new SortedDictionary<string, SortedSet<string>>();
            char[] splitters = new char[] { ' ', '|' };
            foreach (var line in fileContent)
            {
                string[] words = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                string fname = words[0];
                string lname = words[1];
                string course = words[2];

                if (!collection.ContainsKey(course))
                {
                    collection.Add(course, new SortedSet<string>());
                }
                collection[course].Add(fname + " " + lname);
            }

            foreach (var course in collection)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }
    }
}
