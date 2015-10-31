namespace Task13
{
    using System;

    class Program
    {
        static void Main()
        {
            DynamicQueue<int> queue = new DynamicQueue<int>();

            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(98);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }
}
