using System;

namespace TrianglePatterns
{
	class Program
	{
        static int i;
        static int count = 10;
        static int j;
        static char space = ' ';
        static char star = '*';


		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            Console.WriteLine();

            for (j = 1; j <= count; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    if(j>= i)
                    Console.Write(star);
                }Console.WriteLine();
            }
            
		}

		static void DisplayPatternB()
		{
            // your implementation here

            Console.WriteLine();

            for (j = 1; j <= count; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    if (i >= j)
                    {
                        Console.Write(star);
                    }
                    
                }
                Console.WriteLine();
            }
        }

		static void DisplayPatternC()
		{
            // your implementation here
            Console.WriteLine();

            for (j = 1; j <= count; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    if (i<=j)
                        Console.Write(space);
                    else
                        Console.Write(star);
                }
                Console.WriteLine();
            }
        }

		static void DisplayPatternD()
		{
            // your implementation here
            Console.WriteLine();

            for (j = 10; j >= 1; j--)
            {
                for (i = 1; i <= count; i++)
                {
                    if (i >= j)
                        Console.Write(star);
                    else
                        Console.Write(space);
                }
                Console.WriteLine();
            }
        }
	}
}
