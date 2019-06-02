using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int startIndex)
        {
            string x = str.ToString();
            StringBuilder substring = new StringBuilder(x.Substring(startIndex));
            return substring;
        }

        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            string x = str.ToString();
            return new StringBuilder(x.Substring(startIndex, length));
        }
    }
}
