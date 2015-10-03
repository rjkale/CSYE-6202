using System;

namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
        static bool is_prime(int num)
        {
            if (num == 2) return true;
            int i;
            for (i = 2; i < num - 1;)
            {
                if (num % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }

public long FindSumOfPrimeNumbers(int input)
	{
	long sum = 0;
            int count = 2;
            int i = 0;

            while (i <= input)
            {
                if (i == input)
                {
                    break;
                }

                if (is_prime(count))
                {
                    Console.WriteLine("\n" + count);
                    sum = sum + count;
                    i++;
                }
                count++;
            }

            return sum;
		}
	}
}
