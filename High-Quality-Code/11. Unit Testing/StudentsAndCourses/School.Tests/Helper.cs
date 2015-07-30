using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    public static class Helper
    {
        private const int STUDENT_NUMBER_START = 10000;
        public const int STUDENT_NUMBER_END = 99999;

        public static bool isBetween(int value)
        {
            if (STUDENT_NUMBER_START >= value || value >= STUDENT_NUMBER_END)
            {
                return true;
            }
            return false;
        }
    }
}
