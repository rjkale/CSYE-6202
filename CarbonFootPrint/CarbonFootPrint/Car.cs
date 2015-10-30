using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Car:CarbonFootPrint
    {
        public override double CalculateCarbonFootPrint()
        {
            return Quantity * CarbonOut;
        }

        public Car(double carbonOut)
        {
            this.Name = "Car";
            this.CarbonOut = carbonOut;
            this.Quantity = 20;
        }

    }
}
