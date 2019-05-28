using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromChekingInFileLine
{
    class Program
    {
        static bool CanBePalindrome(string inputString)
        {
            char[] sortedArray = inputString.ToCharArray();
            Array.Sort(sortedArray);
            List<char> even = new List<char>();
            List<char> odd = new List<char>();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(sortedArray[i]);
                }
                else
                {
                    odd.Add(sortedArray[i]);
                }
            }
            if (inputString.Length % 2 == 0)
            {
                return new string(odd.ToArray()) == new string(even.ToArray());
            }

            if (new string(even.Except(odd).ToArray()).Length <= 1)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            string path = @"MyFiles\file.txt";

            using (StreamReader stream = new StreamReader(path))
            {
                if (File.Exists(path))
                {
                    string line = stream.ReadLine();
                    int lineCount = 1;
                    Console.Write("Palindrom can be one lines: ");
                    while (line != null)
                    {
                        if (CanBePalindrome(line))
                        {
                            Console.Write($"{lineCount} ");
                        }
                        lineCount++;
                        line = stream.ReadLine();
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
