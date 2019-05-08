using System;
using System.Diagnostics;

namespace SortAlgorithms
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] array1 = new int[10000];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next();
            }

            int[] array2 = new int[10000];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next();
            }

            int[] array3 = new int[10000];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = rand.Next();
            }

            int[] array4 = new int[10000];
            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = rand.Next();
            }
            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            Stopwatch stopWatch3 = new Stopwatch();
            Stopwatch stopWatch4 = new Stopwatch();

            Sorting sort = new Sorting();

            stopWatch1.Start();
            sort.BubbleSort(array1);
            stopWatch1.Stop();
            Console.WriteLine(stopWatch1.Elapsed.TotalSeconds);

            stopWatch2.Start();
            sort.SelectionSort(array2);
            stopWatch2.Stop();
            Console.WriteLine(stopWatch2.Elapsed.TotalSeconds);

            stopWatch3.Start();
            sort.MergeSort(array3, 0, array3.Length - 1);
            stopWatch3.Stop();
            Console.WriteLine(stopWatch3.Elapsed.TotalSeconds);

            stopWatch4.Start();
            sort.QuickSort(array4, 0, array4.Length - 1);
            stopWatch4.Stop();
            Console.WriteLine(stopWatch4.Elapsed.TotalSeconds);
        }
    }
}
