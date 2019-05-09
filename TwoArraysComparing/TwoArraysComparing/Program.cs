using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArraysComparing
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


            int[] array1 = new int[arrayLength];
            int[] array2 = new int[arrayLength];

            do
            {
                if (!correctInput)
                {
                    Console.WriteLine($"\nElements of array must be numbers less than {int.MaxValue} and greater than {int.MinValue}");
                }
                Console.Write("Input elements of first array: ");
                for (int i = 0; i < arrayLength; i++)
                {
                    bool inputArray1 = int.TryParse(Console.ReadLine(), out array1[i]);
                    bool arraNumber1 = array1[i] <= int.MaxValue && array1[i] >= int.MinValue;
                    correctInput = inputArray1 && arraNumber1;
                    if (!correctInput)
                    {
                        break;
                    }
                }
            } while (!correctInput);


            do
            {
                if (!correctInput)
                {
                    Console.WriteLine($"\nElements of array must be numbers less than {int.MaxValue} and greater than {int.MinValue}");
                }
                Console.Write("Input elements of second array: ");
                for (int i = 0; i < arrayLength; i++)
                {
                    bool inputArray2 = int.TryParse(Console.ReadLine(), out array2[i]);
                    bool arraNumber2 = array2[i] <= int.MaxValue && array2[i] >= int.MinValue;
                    correctInput = inputArray2 && arraNumber2;
                    if (!correctInput)
                    {
                        break;
                    }
                }
            } while (!correctInput);


            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrayLength; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("Arrays are not equal");
                    return;
                }
            }

            Console.WriteLine("Arrays are equal");

        }
    }
}
