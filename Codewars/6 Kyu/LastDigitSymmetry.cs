using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class LastDigitSymmetry
    {
        public static bool isPrime(long number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static long GetFirst2Digits(long i)
        {
            if (i >= 1000000) i /= 100000;
            if (i >= 100000) i /= 10000;
            if (i >= 10000) i /= 1000;
            if (i >= 1000) i /= 100;
            if (i >= 100) i /= 10;
            return i;
        }
        public static long GetLast2Digits(long number)
        {
            return number % 100;
        }
        public static int Solve(int min, int max)
        {

            int sum = 0;
            for (long i = min; i <= max; i++)
            {
                long pow2 = i * i;
                if (isPrime(GetFirst2Digits(i)) &&
                    isPrime(GetFirst2Digits(pow2)) &&
                            GetLast2Digits(i) == GetLast2Digits(pow2))
                    sum++;
            }
            return sum;
        }
    }
}
