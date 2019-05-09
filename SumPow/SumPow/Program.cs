using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPow
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;
            bool correctInput = true;

            do
            {
                if (!correctInput)
                {
                    Console.WriteLine("\nThe size of array must be a number less than 100 and greater than 0");
                }
                Console.Write("Input array size: ");
                bool input = int.TryParse(Console.ReadLine(), out arrayLength);
                bool inputNumber = arrayLength > 0 && arrayLength <= 100;
                correctInput = input && inputNumber;

            } while (!correctInput);


            Random rand = new Random();
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(-99, 99);
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            double sum = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] < 0)
                {
                    sum += Math.Pow(array[i], 2);
                }
            }

            Console.WriteLine($"Result: {sum}");
        }
    }
}
