using System;
using System.Diagnostics;

namespace CompareSimpleMaths
{

    public static class MathPerformance
    {
        private const int INTEGER_VALUE = 1;
        private const long LONG_VALUE = 1L;
        private const float FLOAT_VALUE = 1f;
        private const double DOUBLE_VALUE = 1;
        private const decimal DECIMAL_VALUE = 1m;
        private const int NUMBER_OF_CALCULATIONS = 1000000;
        private static Stopwatch stopWatch = new Stopwatch();

        public static void Performance(Operation operation)
        {
            int resultInt = 1;
            stopWatch.Start();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultInt += INTEGER_VALUE;
                        break;
                    case Operation.Subtracion:
                        resultInt -= INTEGER_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultInt *= INTEGER_VALUE;
                        break;
                    case Operation.Division:
                        resultInt /= INTEGER_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Console.WriteLine("The {0} for type int took {1}", operation, stopWatch.Elapsed);

            long resultLong = 1;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultLong += LONG_VALUE;
                        break;
                    case Operation.Subtracion:
                        resultLong -= LONG_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultLong *= LONG_VALUE;
                        break;
                    case Operation.Division:
                        resultLong /= LONG_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Console.WriteLine("The {0} for type long took {1}", operation, stopWatch.Elapsed);

            float resultFloat = 1f;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultFloat += FLOAT_VALUE;
                        break;
                    case Operation.Subtracion:
                        resultFloat -= FLOAT_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultFloat *= FLOAT_VALUE;
                        break;
                    case Operation.Division:
                        resultFloat /= FLOAT_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Console.WriteLine("The {0} for type float took {1}", operation, stopWatch.Elapsed);

            double resultDouble = 1;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDouble += DOUBLE_VALUE;
                        break;
                    case Operation.Subtracion:
                        resultDouble -= DOUBLE_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultDouble *= DOUBLE_VALUE;
                        break;
                    case Operation.Division:
                        resultDouble /= DOUBLE_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Console.WriteLine("The {0} for type double took {1}", operation, stopWatch.Elapsed);

            decimal resultDecimal = 1m;
            stopWatch.Restart();
            for (int i = 0; i < NUMBER_OF_CALCULATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDecimal += DECIMAL_VALUE;
                        break;
                    case Operation.Subtracion:
                        resultDecimal -= DECIMAL_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultDecimal *= DECIMAL_VALUE;
                        break;
                    case Operation.Division:
                        resultDecimal /= DECIMAL_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Console.WriteLine("The {0} for type decimal took {1}", operation, stopWatch.Elapsed);

            stopWatch.Stop();
            stopWatch.Reset();
        }
    }
}