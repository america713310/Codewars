using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class SumOfSequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            while (start <= end)
            {
                return start + SequenceSum(start + step, end, step);
            }
            return 0;
        }
    }
}
