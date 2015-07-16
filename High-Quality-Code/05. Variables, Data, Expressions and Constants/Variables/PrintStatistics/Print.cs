using System;

class Print
{
    public void PrintStatistics(double[] arr, int count)
    {
        double maxElement = arr[0];

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
            }
        }
        
        double minElement = arr[0];

        for (int i = 0; i < count; i++)
        {
            if (arr[i] < minElement)
            {
                maxElement = arr[i];
            }
        }

        double sumOfArrayElements = 0;
        for (int i = 0; i < count; i++)
        {
            sumOfArrayElements += arr[i];
        }

        Print(maxElement);
        Print(minElement);
        Print(sumOfArrayElements / count);
    }

    public void Print(double value)
    {
        Console.WriteLine(value);
    }

}