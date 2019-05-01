using System;
using System.Numerics;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger prev1 = new BigInteger(1);
            BigInteger prev2 = new BigInteger(1);
            BigInteger fib = new BigInteger(1);

            for (int i = 2; i < n; i++)
            {
                fib = 0;
                fib = prev2 + prev1;
                prev1 = prev2;
                prev2 = fib;
            }

            Console.WriteLine($"Fibonacci number for {n} is {fib}");
        }
    }
}
