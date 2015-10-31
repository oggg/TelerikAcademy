namespace Task9
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            UsingQueue(2, 50);
        }

        private static void UsingQueue(int startValue, int numberOfMembers)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startValue);
            int counter = 0;

            while (queue.Count < numberOfMembers - counter)
            {
                ++counter;
                var current = queue.Dequeue();
                Console.Write("{0} ", current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            for (int i = 0; i < numberOfMembers - counter; i++)
            {
                Console.Write("{0} ", queue.Dequeue());
            }
        }
    }
}
