using System;
using System.Numerics;

namespace FactorialCountOfZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = new BigInteger(1);
            int count = 0;
            bool input;
            int num;

            do
            {
                Console.Write("Enter number: ");
                input = int.TryParse(Console.ReadLine(), out num);
            } while (!input);

            for (int i = 1; i <= num; i++)
            {
                result *= i;
                if (i % 5 == 0)
                {
                    count++;
                    if (i % 25 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(result);
            Console.WriteLine($"Number of zeros in the end is: {count}");
        }
    }
}
