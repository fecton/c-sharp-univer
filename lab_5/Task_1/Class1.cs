using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba05
{
    public class Class1
    {
        // int,string
        // рядок у якому видалено символ з індексом m

        public static string RemoveSymbol(string radok, int index)
        {
            radok = radok.Remove(index, 1);
            return radok;
        }
        
        // int, string
        // рядок, в якому перші n символів замінено на *

        public static string ReplaceSymbols(string radok, int n)
        {
            StringBuilder sb = new StringBuilder(radok);
            for(int index = 0; index < n; index++)
            {
                sb[index] = '*';
            }
            return sb.ToString();
        }
    }
}
