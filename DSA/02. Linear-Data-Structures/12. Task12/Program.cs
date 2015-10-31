using System;

namespace Task12
{
    class Program
    {
        static void Main()
        {
            DynamicStack<int> stack = new DynamicStack<int>();

            stack.Push(2);
            stack.Push(7);
            Console.WriteLine(stack.Count);
            stack.Push(4);

            Console.WriteLine(stack.Top);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(7));
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            stack.Clear();
            Console.WriteLine(stack.Top);
        }
    }
}
