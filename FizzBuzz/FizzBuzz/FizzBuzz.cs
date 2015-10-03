using System;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int input)
		{

            if (input % 3 == 0 && input % 5 == 0)
            { return "FIZZ BUZZ"; }

            else if (input % 3 == 0)
            { return  "FIZZ"; }

            else if (input % 5 == 0)
            { return "BUZZ"; }

            else {

                    string result = input.ToString();
                    return result;
                 }

            


        }
	}
}
