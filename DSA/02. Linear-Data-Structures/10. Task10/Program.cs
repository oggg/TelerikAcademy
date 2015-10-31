namespace Task10
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int N = 5;
            int M = 16;
            Queue<int?> result = new Queue<int?>();
            result = OperationValues(N, M, result);

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }

        private static Queue<int?> OperationValues(int start, int end, Queue<int?> result)
        {
            if (end <= start)
            {
                result.Enqueue(null);
                return result;
            }

            result.Enqueue(end);
            if ((end % 2 != 0) && (start * 2 < end))
            {
                end -= 1;
                result.Enqueue(end);
            }

            end = Divider(start, end, result);
            end = MinusTwo(start, end, result);
            end = MinusOne(start, end, result);

            return result;
        }

        private static int Divider(int start, int end, Queue<int?> result)
        {
            while (end >= start)
            {
                if ((end % 2 != 0) && (end - 1 > start))
                {
                    end -= 1;
                    result.Enqueue(end);
                }
                end /= 2;
                if (end >= start)
                {
                    result.Enqueue(end);
                }
            }

            if (end < start)
            {
                end *= 2;
            }

            return end;
        }

        private static int MinusTwo(int start, int end, Queue<int?> result)
        {
            while (end >= start)
            {
                end -= 2;
                if (end >= start)
                {
                    result.Enqueue(end);
                }
            }

            if (end < start)
            {
                end += 2;
            }

            return end;
        }

        private static int MinusOne(int start, int end, Queue<int?> result)
        {
            while (end >= start)
            {
                end -= 1;
                if (end >= start)
                {
                    result.Enqueue(end);
                }
            }

            if (end < start)
            {
                end += 1;
            }

            return end;
        }
    }
}
