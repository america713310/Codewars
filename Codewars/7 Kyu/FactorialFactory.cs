using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class FactorialFactory
    {
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new Exception();
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
