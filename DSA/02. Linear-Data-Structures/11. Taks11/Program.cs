namespace Taks11
{
    using System;

    class Program
    {
        static void Main()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(5);
            linkedList.Add(4);
            linkedList.Add(15);

            Console.WriteLine(linkedList.FirstElement);
            Console.WriteLine(linkedList.FirstElement.NextItem);
            Console.WriteLine(linkedList.FirstElement.NextItem.NextItem);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
