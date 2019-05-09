using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingNumberCount
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
                    Console.WriteLine("The size of the array must be a number less than 100 and greater than 0");
                }
                Console.Write("Input size of array: ");
                bool input = int.TryParse(Console.ReadLine(), out arrayLength);
                bool inputNumber = arrayLength > 0 && arrayLength <= 100;
                correctInput = input && inputNumber;

            } while (!correctInput);

            int[] array = new int[arrayLength];

            do
            {
                if (!correctInput)
                {
                    Console.WriteLine($"\nElements of array must be numbers less than {int.MaxValue} and greater than {int.MinValue}");
                }
                Console.Write("Input array elements: ");
                for (int i = 0; i < arrayLength; i++)
                {
                    bool inputArray1 = int.TryParse(Console.ReadLine(), out array[i]);
                    bool arraNumber1 = array[i] <= int.MaxValue && array[i] >= int.MinValue;
                    correctInput = inputArray1 && arraNumber1;
                    if (!correctInput)
                    {
                        break;
                    }
                }
            } while (!correctInput);

            List<int> increasingNumbers = new List<int>();
            int min = int.MaxValue;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i; j < arrayLength; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                    }
                }
                if (increasingNumbers.Count == 0 || increasingNumbers.Last() < min)
                {
                    increasingNumbers.Add(min);
                }
                min = int.MaxValue;
            }

            Console.WriteLine();
            for (int i = 0; i < increasingNumbers.Count; i++)
            {
                Console.Write(increasingNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
