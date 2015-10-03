using System;

namespace FindingPrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
            int input;

            Console.WriteLine("Enter N prime numbers you want");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("\n0");
            }
            else
            {
                FindingPrimeNumbers findprime = new FindingPrimeNumbers();
                long output = findprime.FindSumOfPrimeNumbers(input);

                Console.WriteLine("\nThe sum of Prime numbers is " + output);
                Console.ReadLine();
            }




        }
    }
}
																																																		