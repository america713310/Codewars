using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class GreatestCommonDivisor
    {
        public static int Gcd(int a, int b)
        {
            if (a == 1)
                return 1;
            if (b == 1)
                return 1;
            if (a == b)
                return a;
            int c = 1;
            if (a > b) c = b;
            else c = a;
            return GetDivisor(a, b, c);
        }
        public static int GetDivisor(int x, int y, int z)
        {
            if (x % z == 0 && y % z == 0)
                return z;
            else
            {
                z--;
                return GetDivisor(x, y, z);
            }
        }

        //public static int Gcd(int a, int b)
        //{
        //    if (b >= 1)
        //        return Gcd(b, a % b);
        //    else
        //        return a;
        //}

        //public static int Gcd(int a, int b)
        //{
        //    int hcf = 1;
        //    int lowest = Math.Min(a, b);
        //    int highest = Math.Max(a, b);

        //    while (lowest != 0)
        //    {
        //        hcf = highest % lowest;
        //        highest = lowest;
        //        lowest = hcf;
        //    }

        //    return highest;
        //}
    }
}
