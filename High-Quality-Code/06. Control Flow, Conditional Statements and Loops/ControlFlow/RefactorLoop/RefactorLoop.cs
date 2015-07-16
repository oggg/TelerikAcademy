using System;

namespace RefactorLoop
{
    class RefactorLoop
    {
        static void Main()
        {

            //int i = 0;
            //for (i = 0; i < 100; )
            //{
            //    if (i % 10 == 0)
            //    {
            //        Console.WriteLine(array[i]);
            //        if (array[i] == expectedValue)
            //        {
            //            i = 666;
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[i]);
            //        i++;
            //    }
            //}
            //// More code here
            //if (i == 666)
            //{
            //    Console.WriteLine("Value Found");
            //}


            int[] array = new int[100];
            int expectedValue = 50;
            bool foundValue = false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == expectedValue)
                {
                    foundValue = true;
                    break;
                }

            }
            // More code here
            if (foundValue)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
