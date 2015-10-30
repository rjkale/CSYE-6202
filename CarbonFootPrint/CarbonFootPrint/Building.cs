using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    public class Building : CarbonFootPrint
    {
        public override double CalculateCarbonFootPrint()
        {
            return Quantity * CarbonOut;
        }

        public Building(double carbonOut)
        {
            this.Name = "Building";
            this.CarbonOut =carbonOut;
            this.Quantity = 50;
        }
    }
}
