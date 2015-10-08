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
            while (true)
            {

            Console.WriteLine("\nWelcome! \n Gas Type \n R/r = Regular Gas \n M/m = MidgradeGas \n P/p = PremiumGas \n D/d = DieselFuel ");
            Console.WriteLine("\nPlease enter the Purchased Gas Type");
            String input = Convert.ToString(Console.ReadLine());
            
            
            if(UserEnteredValidGasType(input))
            {
                    char inputchar = Convert.ToChar(input);
                    GasType gt = GasTypeMapper(inputchar);
                    Double gpm = GasPriceMapper(gt);

                    //Get the value of purchased gas amount from the user

                    Console.WriteLine("\nPlease enter purchased gas amount");
                    string pamount = Convert.ToString(Console.ReadLine());

               
                    if(UserEnteredValidAmount(pamount))
                    {
                        Console.WriteLine("\nYou bought " + pamount + " gallons of "+gt + " at the Price of " + gpm);
                        double totalcost = 0;
                        CalculateTotalCost(gt, int.Parse(pamount), ref totalcost );
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid purchase amount");
                    }
            }//end if inner
            else
            {
                Console.WriteLine("\nPlease enter a valid option\n");
                    
            }//end else

            }//End of While loop


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

            if (userInput == "m" || userInput == "M")
            {
                result = true;
            }

            if (userInput == "p" || userInput == "P")
            {
                result = true;
            }

            if (userInput == "d" || userInput == "D")
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
            double n;
            if (Double.TryParse(userInput, out n))
            {   
                result = true;
                return result;
            }
            else
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

                case 'M':
                case 'm':
                    {
                        GasType gasType = GasType.MidgradeGas;
                        return gasType;
                    }

                case 'P':
                case 'p':
                    {
                        GasType gasType = GasType.PremiumGas;
                        return gasType;
                    }

                case 'D':
                case 'd':
                    {
                        GasType gasType = GasType.DieselFuel;
                        return gasType;
                    }

                default: return GasType.None;
               }//end of switch
        }

		public static double GasPriceMapper(GasType gasType)
        {
			var result = 0.0;
            switch (gasType)
            {
                case GasType.None:
                    result = 0;
                    break;
                    
                case GasType.RegularGas:
                    result= 1.94;
                    break;
                    
                case GasType.MidgradeGas:
                    result = 2.00;
                    break;
                    
                case GasType.PremiumGas:
                    result = 2.24;
                    break;

                case GasType.DieselFuel:
                    result = 2.17;
                    break;
            }

            return result;
	    }

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            double gPriceMapper = GasPriceMapper(gasType);
            double TotalPrice = gPriceMapper * gasAmount;
            Console.WriteLine("\nYour total cost for this purchase is: " +TotalPrice);   			
		}
	}
}
