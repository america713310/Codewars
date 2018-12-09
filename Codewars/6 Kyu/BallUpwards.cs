using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class BallUpwards
    {
        public static int MaxBall(int v0)
        {
            Dictionary<int, double> _dictionary = new Dictionary<int, double>();
            double h = 0, v = v0 / 3.6, i = 0.1;
            int _count = 0;
            do
            {
                h += v * i - 0.5 * 9.81 * i * i;
                v = v - 9.81 * i;
                _count++;
                _dictionary.Add(_count, h);
            }
            while (v > 0);
            int _answer = _dictionary.OrderBy(x => x.Value).Last().Key;
            return _answer;
        }
    }
}

