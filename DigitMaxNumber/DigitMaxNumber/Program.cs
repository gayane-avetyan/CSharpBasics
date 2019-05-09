using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitMaxNumber
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
                array[i] = rand.Next(1, 9);
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Array.Sort(array);

            int count = 1;
            int max = 0;
            int number = array[0];

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == arrayLength - 1 || array[i] != array[i + 1])
                {
                    count = 1;
                }
                else
                {
                    count++;
                }

                if (max <= count)
                {
                    max = count;
                    number = array[i];
                }
            }
            Console.WriteLine("number: " + number);
            Console.WriteLine("count: " + max);
        }
    }
}
