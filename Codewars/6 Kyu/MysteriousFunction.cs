using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class MysteriousFunction
    {
        public static int GetNum(long a)
        {
            int count = 0;
            while (a > 0)
            {
                if (a % 10 == 0 || a % 10 == 6 || a % 10 == 9)
                    count++;
                else if (a % 10 == 8)
                    count += 2;
                a /= 10;
            }
            return (count);
        }
    }
}
