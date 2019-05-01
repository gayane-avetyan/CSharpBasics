using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input;
            do
            {
                Console.Write("Enter number: ");
                input = int.TryParse(Console.ReadLine(), out int n);
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }

            } while (!input);
            Console.WriteLine();
        }
    }
}
