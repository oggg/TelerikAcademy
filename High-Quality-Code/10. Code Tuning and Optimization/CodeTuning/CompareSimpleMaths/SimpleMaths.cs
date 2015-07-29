using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    class SimpleMaths
    {
        static void Main()
        {
            MathPerformance.Performance(Operation.Addition);
            MathPerformance.Performance(Operation.Division);
            MathPerformance.Performance(Operation.Multiplication);
            MathPerformance.Performance(Operation.Subtracion);
        }
    }
}
