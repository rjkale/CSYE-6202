using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CarbonFootPrint> FootPrintList = new List<CarbonFootPrint>();
            Bicycle bicycle = new Bicycle(10);
            Car car = new Car(100);
            Building building = new Building(200);

            FootPrintList.Add(bicycle);
            FootPrintList.Add(car);
            FootPrintList.Add(building);


            foreach (var type in FootPrintList)
            {   
                Console.WriteLine("The CarbonFootPrint of " + type.Name + " is "  + type.CalculateCarbonFootPrint());
            }
            Console.ReadLine();
        }
    }
}
