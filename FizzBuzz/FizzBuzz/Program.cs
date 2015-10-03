using System;

namespace FizzBuzz
{
	class Program
	{
	static void Main(string[] args)
	    {
            while (true)
            {

        
            Console.WriteLine("Enter a Number"); 
            int input = Convert.ToInt32(Console.ReadLine());

            FizzBuzz fb = new FizzBuzz();
            string output = fb.RunFizzBuzz(input); 

            Console.WriteLine(output);
            Console.ReadLine();
            }
        }
	}
}
