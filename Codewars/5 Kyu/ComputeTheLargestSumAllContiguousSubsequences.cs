using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class ComputeTheLargestSumAllContiguousSubsequences
    {
        public static int LargestSum(int[] arr)
        {
            int _current = 0;
            int _sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                _current = _current + arr[i];

                if (_current < 0)
                {
                    _current = 0;
                }

                if (_sum < _current)
                {
                    _sum = _current;
                }
            }
            return _sum;
            //int maxAt = 0;
            //return arr.Length > 0 ? arr.Max(n => maxAt = Math.Max(0, maxAt + n)) : 0;
        }
    }
}
