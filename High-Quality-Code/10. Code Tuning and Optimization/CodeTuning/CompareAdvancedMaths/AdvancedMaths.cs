using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMaths
{
    class AdvancedMaths
    {
        static void Main()
        {
            MathPerformance.Performance(Operation.Square);
            MathPerformance.Performance(Operation.Logarithm);
            MathPerformance.Performance(Operation.Sinus);
        }
    }
}
