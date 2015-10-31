namespace Task8
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var groups = arr.GroupBy(num => num);
            int criterion = (arr.Length / 2) + 1;

            int? majorant = null;

            foreach (var group in groups)
            {
                if (group.Count() >= criterion)
                {
                    majorant = group.Key;
                }
            }

            if (majorant != null)
            {
                Console.WriteLine(majorant);
            }
            else
            {
                Console.WriteLine("There is no majorant in this array");
            }

        }
    }
}
