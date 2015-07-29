using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMaths
{
    public static class CastPerformance
    {
        private static Stopwatch stopWatch = new Stopwatch();
        private const int NUMBER_OF_OPERATIONS = 1000000;
        private static double CastTo;

        public static TimeSpan FoatToDouble()
        {
            float castFrom = 1f;
            stopWatch.Start();

            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                CastTo = castFrom;
                castFrom = (float)CastTo;
            }

            var result = stopWatch.Elapsed;
            stopWatch.Stop();
            stopWatch.Reset();
            return result;
        }

        public static TimeSpan DecimalToDouble()
        {
            decimal castFrom = 1m;
            stopWatch.Start();

            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                CastTo = (double)castFrom;
                castFrom = (decimal)CastTo;
            }
            
            var result = stopWatch.Elapsed;
            stopWatch.Stop();
            stopWatch.Reset();
            return result;
        }
    }
}
