using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version("2.11")]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
