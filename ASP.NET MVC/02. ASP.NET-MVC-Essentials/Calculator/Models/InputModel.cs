using System.Collections.Generic;

namespace Calculator.Models
{
    public class InputModel
    {
        public double Quantity { get; set; }

        public IList<SystemSiType> Type { get; set; }

        public IList<int> Kilo { get; set; }
    }
}
