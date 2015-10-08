using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{
            // your implementation here
            Console.WriteLine("Welcome! \n Gas Type \n R/r = Regular Gas \n M/m = MidgradeGas \n P/p = PremiumGas \n D/d = DieselFuel ");
            Console.WriteLine("\nPlease enter the Purchased Gas Type");
            String input = Convert.ToString(Console.ReadLine());
            while (true)
            {
            
            if(UserEnteredValidGasType(input))
            {
                Console.WriteLine("Its a regular Gas");
                    char inputchar = Convert.ToChar(input);

                    GasType gt = GasTypeMapper(inputchar);
                    Double gpm = GasPriceMapper(gt);
                    Console.WriteLine("You Brought" + inputchar + " and the Price of the gas is " +gpm);


                    break;
                
            }//end if
            else
            {
                Console.WriteLine("Please enter a valid option");
                    break;
            }//end else

            }//End of While loop

            Console.ReadLine();
        }//End of main function

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

			

			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

            if(userInput == "r" || userInput == "R")
            {
                result = true;
            }
			
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

			

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			

            switch (c)
            {

                case 'R':
                case 'r':
                    {
                        GasType gasType = GasType.RegularGas;
                        return gasType;
                    }

                default: throw new ArgumentOutOfRangeException();
            }//end of switch

            
            //GasType gasType = GasType.None;
        }

		public static double GasPriceMapper(GasType gasType)
        {
			var result = 0.0;
            switch (gasType)
            {
                case GasType.None:
                    return 0;
                    
                case GasType.RegularGas:
                    return 1.94;
                    
                case GasType.MidgradeGas:
                    return 2.00;
                    
                case GasType.PremiumGas:
                    return 2.24;

                case GasType.DieselFuel:
                    return 2.17;

            }


            return result;
	    }

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
			
		}
	}
}
