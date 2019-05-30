using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLinesOfFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFiles\file.txt";
            using (StreamReader stream = new StreamReader(path))
            {
                string line = stream.ReadLine();
                int lineCount = 1;           
                while (line != null)
                {
                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine($"{lineCount} {line}");
                    }
                    line = stream.ReadLine();
                    lineCount++;
                }
            }
        }
    }
}
