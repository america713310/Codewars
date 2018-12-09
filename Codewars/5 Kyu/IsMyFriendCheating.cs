using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class IsMyFriendCheating
    {
        public static List<long[]> RemovNb(long n)
        {
            int _sum = 0;
            for (int i = 1; i <= n; i++)
            {
                _sum += i;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i * j == _sum - i - j)
                        return new List<long[]>() { new long[] { i, j }, new long[] { j, i } };
                }
            }
            return null;
        }
    }
}
