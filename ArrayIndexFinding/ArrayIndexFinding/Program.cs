using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexFinding
{
    class Program
    {
        static int BinarySearch_Iter(int[] array, int key)
        {
            int left = 0;
            int right = array.Length;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + (right - left) / 2;

                if (array[mid] == key)
                    return mid;

                if (array[mid] > key)
                    right = mid;
                else
                    left = mid + 1;
            }

            return -(1 + left);
        }

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

            Array.Sort(array);

            Console.WriteLine("Sorted array");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int value;

            Console.WriteLine();
            do
            {
                Console.Write("Enter value: ");
                bool valueInput = int.TryParse(Console.ReadLine(), out value);

                for (int i = 0; i < arrayLength; i++)
                {
                    if (value == array[i])
                    {
                        correctInput = true;
                        break;
                    }
                    correctInput = false;
                }
            } while (!correctInput);


            int left = 0;
            int right = arrayLength;
            int mid = 0;

            for (int i = 0; i < 10; i++)
            {
                mid = (right + left) / 2;
                if (value >= array[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }

            }
            Console.WriteLine($"index of {value} is {mid}");
        }
    }
}
