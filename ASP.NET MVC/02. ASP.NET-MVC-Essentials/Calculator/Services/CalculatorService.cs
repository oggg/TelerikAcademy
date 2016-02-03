using System;
using System.Collections.Generic;
using System.Linq;
using Calculator.Models;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public CalculatorService(int q, int k, string t)
        {
            this.Quantity = q;
            this.Kilo = k;
            this.Type = t;
        }

        public int Quantity { get; set; }
        public int Kilo { get; set; }
        public string Type { get; set; }

        public List<SystemSiType> Result()
        {
            int power = Constants.Types.Where(x => x.Name == this.Type).Select(x => x.Power).FirstOrDefault();
            var result = new List<SystemSiType>(Constants.Types);
            double byteFactor = 1;



            foreach (var si in result)
            {
                if (si.Byte == true && this.Type.Contains("byte"))
                {
                    byteFactor = 1;
                }
                else if (si.Byte == true && this.Type.Contains("bit"))
                {
                    byteFactor = 1 / 8.0;
                }
                else if (si.Byte == false && this.Type.Contains("byte"))
                {
                    byteFactor = 8;
                }
                else if (si.Byte == false && this.Type.Contains("bit"))
                {
                    byteFactor = 1;
                }
                si.Value = this.Quantity * byteFactor * (Math.Pow(this.Kilo, power - si.Power));
            }

            return result;
        }
    }
}
