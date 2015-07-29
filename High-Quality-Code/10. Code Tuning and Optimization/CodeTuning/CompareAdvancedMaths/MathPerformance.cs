using System;
using System.Diagnostics;

namespace CompareAdvancedMaths
{

    public static class MathPerformance
    {
        private const double DOUBLE_VALUE = 50;
        private const int NUMBER_OF_CALCULATIONS = 1000000;
        private static Stopwatch stopWatch = new Stopwatch();

        public static void Performance(Operation operation)
        {
            double resultDouble = 1;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Square:
                        resultDouble = Math.Sqrt(DOUBLE_VALUE);
                        break;
                    case Operation.Logarithm:
                        resultDouble = Math.Log(DOUBLE_VALUE);
                        break;
                    case Operation.Sinus:
                        resultDouble = Math.Sin(DOUBLE_VALUE);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            var stopWatchResult = stopWatch.Elapsed;
            stopWatch.Stop();
            stopWatch.Reset();

            Console.WriteLine("The {0} for type double took {1}", operation, stopWatchResult);

            var floatToDoubleDelay = CastPerformance.FoatToDouble();
            Console.WriteLine("The {0} for type float took {1}", operation, stopWatchResult + floatToDoubleDelay);

            var decimalToDoubleDelay = CastPerformance.DecimalToDouble();
            Console.WriteLine("The {0} for type float took {1}", operation, stopWatchResult + decimalToDoubleDelay);
        }
    }
}