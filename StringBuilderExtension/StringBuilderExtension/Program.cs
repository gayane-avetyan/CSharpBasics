using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("123456789");
            Console.WriteLine(str.Substring(2, 4));
        }
    }
}
