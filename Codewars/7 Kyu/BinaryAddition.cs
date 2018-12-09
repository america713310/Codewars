using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }
    }
}
