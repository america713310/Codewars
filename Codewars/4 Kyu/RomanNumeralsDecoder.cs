using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            Dictionary<string, int> _dictionary = new Dictionary<string, int>();
            int _count = 0;

            _dictionary.Add("I", 1);
            _dictionary.Add("V", 5);
            _dictionary.Add("X", 10);
            _dictionary.Add("L", 50);
            _dictionary.Add("C", 100);
            _dictionary.Add("D", 500);
            _dictionary.Add("M", 1000);
            for (int i = 0; i < roman.Length; i++)
            {
                if (i == roman.Length - 1)
                {
                    _count += _dictionary.Where(x => x.Key == roman[i].ToString()).First().Value;
                    break;
                }
                int _current = _dictionary.Where(x => x.Key == roman[i].ToString()).First().Value;
                int _next = _dictionary.Where(x => x.Key == roman[i+1].ToString()).First().Value;
                _count = _next > _current ? _count -= _current : _count += _current;
            }
            return _count;
        }
    }
}
