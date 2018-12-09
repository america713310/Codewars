using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class ConvertToBinaryHex
    {
        public static int ConvertBinaryHex(int n)
        {
            Console.WriteLine(Convert.ToString(n, 8));
            Console.WriteLine(Convert.ToString(n, 10));
            Console.WriteLine(Convert.ToString(n, 16));

            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
