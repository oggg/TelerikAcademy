using System;

namespace Abstraction
{
    public static class Validator
    {
        public static void FigureSize(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The provided value is not appropriate for a figure");
            }
        }
    }
}
