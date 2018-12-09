using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class ArrayDifference
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> _list = new List<int>();
            bool isContains;
            
            for (int i = 0; i < a.Length; i++)
            {
                isContains = false;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        isContains = true;
                }
                if (!isContains)
                    _list.Add(a[i]);
            }
            int[] _answer = new int[_list.Count];
            for (int i = 0; i < _answer.Length; i++)
            {
                _answer[i] = _list[i];
            }
            return _answer;
            // return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
