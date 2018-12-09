using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class TortoiseRacing
    {
        public static int[] Race(int v1, int v2, int g)
        {
            int[] _array = new int[3];
            int _time = 0, _hours = 0, _minutes = 0, _seconds = 0;

            if (v2 <= v1)
            {
                return null;
            }
            _time = g * 3600 / (v2 - v1);
            _hours = _time / 3600;
            _minutes = (_time - _hours * 3600) / 60;
            _seconds = _time - _hours * 3600 - _minutes * 60;
            _array[0] = _hours;
            _array[1] = _minutes;
            _array[2] = _seconds;
            return _array;
        }
    }
}
