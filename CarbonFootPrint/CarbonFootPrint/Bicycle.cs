using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Bicycle:CarbonFootPrint
    {
        public override double CalculateCarbonFootPrint()
        {
            return Quantity * CarbonOut;
        }

        public Bicycle(double carbonOut)
        {
            this.Name = "Bicycle";
            this.CarbonOut = carbonOut;
            this.Quantity = 0;
        }
    }
}
