using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathNames = @"MyFiles\names.txt";
            string pathSortedNames = @"MyFiles\sortedNames.txt";
            List<string> names = new List<string>();
            using (StreamReader stream = new StreamReader(pathNames))
            {
                string line = stream.ReadLine();
                while (line != null)
                {
                    names.Add(line);
                    line = stream.ReadLine();
                }
            }
            names.Sort();
            using (FileStream stream = new FileStream(pathSortedNames, FileMode.Append))
            {
                foreach (var item in names)
                {
                    byte[] array = Encoding.Default.GetBytes(item);
                    stream.Write(array, 0, array.Length);
                }
            }
        }
    }
}
