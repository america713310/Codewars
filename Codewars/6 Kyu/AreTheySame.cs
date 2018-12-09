using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class AreTheySame
    {
        public static bool Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;
            List<int> _listA = new List<int>(a);
            List<int> _listB = new List<int>(b);

            if (_listA.Count != _listB.Count)
                return false;
            int _count = 0;

            _listA.Sort();
            _listB.Sort();
            for (int i = 0; i < _listA.Count; i++)
            {
                if (_listA[i] * _listA[i] == _listB[i])
                    _count++;
            }
            if (_count == a.Length)
                return true;
            else return false;
        }
    }
}
