using System;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int input)
		{
            if (input == 0)
                return "0";

            if (input % 3 == 0 && input % 5 == 0)
            { return "FizzBuzz"; }

            else if (input % 3 == 0)
            { return  "Fizz"; }

            else if (input % 5 == 0)
            { return "Buzz"; }

            else {

                    string result = input.ToString();
                    return result;
                 }
            
        }
	}
}
