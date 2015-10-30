using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    public abstract class CarbonFootPrint
    {
        public String Name { get; set; }
        public Double CarbonOut { get; set; }
        public double Quantity { get; set; }
        public abstract double CalculateCarbonFootPrint();
    }
}
