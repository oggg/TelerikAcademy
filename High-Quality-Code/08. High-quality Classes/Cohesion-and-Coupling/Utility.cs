using System;

namespace CohesionAndCoupling
{
    public static class Utility
    {
        public static int DotIndex(string fileName)
        {
            if (fileName == string.Empty)
            {
                throw new ArgumentNullException("No filename provided");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            return indexOfLastDot;
        }

        public static void SizeCheck(double size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size should be bigger than zero");
            }
        }
    }
}
