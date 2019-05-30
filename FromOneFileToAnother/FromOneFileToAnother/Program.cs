using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromOneFileToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"MyFiles\first.txt";
            string path2 = @"MyFiles\second.txt";
            using (FileStream stream = new FileStream(path2, FileMode.Append))
            {
                using (StreamReader read = new StreamReader(path1))
                {
                    string line = read.ReadLine();
                    int lineCount = 1;
                    while (line != null)
                    {                                               
                        byte[] array = Encoding.Default.GetBytes($"{lineCount} {line}");
                        line = read.ReadLine();
                        stream.Write(array, 0, array.Length);
                        lineCount++;
                    }
                }
            }
        }
    }
}
