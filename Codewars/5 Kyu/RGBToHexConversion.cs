using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class RGBToHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            int[] _array = new int[3];
            string _r, _g, _b;

            _array[0] = r; _array[1] = g; _array[2] = b;
            for (int i = 0; i < 3; i++)
            {
                if (_array[i] < 0)
                    _array[i] = 0;
                if (_array[i] > 255)
                    _array[i] = 255;
            }
            _r = _array[0].ToString("X");
            _g = _array[1].ToString("X");
            _b = _array[2].ToString("X");
            if (_r == "0")
                _r = "00";
            if (_g == "0")
                _g = "00";
            if (_b == "0")
                _b = "00";
            if (_r.Length == 1)
                _r = "0" + _r;
            if (_g.Length == 1)
                _g = "0" + _g;
            if (_b.Length == 1)
                _b = "0" + _b;
            return _r + _g + _b;
        }
    }
}
