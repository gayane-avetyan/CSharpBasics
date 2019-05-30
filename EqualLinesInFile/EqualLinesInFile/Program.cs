using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualLinesInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"MyFiles\first.txt";
            string path2 = @"MyFiles\second.txt";
      
            int equalLinesCount = 0;
            int notEqualLinesCount = 0;
            using (StreamReader stream1 = new StreamReader(path1))
            {
                using (StreamReader stream2 = new StreamReader(path2))
                {
                    string lineOfFirstFile = stream1.ReadLine();
                    string lineOfSecondFile = stream2.ReadLine();
                    while (lineOfFirstFile != null)
                    {
                        if (lineOfFirstFile.Equals(lineOfSecondFile))
                        {
                            equalLinesCount++;
                        }
                        else
                        {
                            notEqualLinesCount++;
                        }
                        lineOfFirstFile = stream1.ReadLine();
                        lineOfSecondFile = stream2.ReadLine();
                    }
                    
                }
            }

            Console.WriteLine($"Equal lines count: { equalLinesCount}");
            Console.WriteLine($"Not equal lines count: { notEqualLinesCount}");
        }
    }
}
