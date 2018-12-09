using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class TheBookOfMormon
    {
        public static long Mormons(long startingNumber, long reach, long target)
        {
            int _count = 0;

            while (startingNumber < target)
            {
                _count++;
                return _count + Mormons(startingNumber + startingNumber * reach, reach, target);
            }
            return 0;
        }
    }
}
