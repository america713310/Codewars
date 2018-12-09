using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class BackwardsReadPrimes
    {
        public static string BackwardsPrime(long start, long end)
        {
            int _count = 0;
            List<string> _list = new List<string>();

            if (start < 12)
                start = 13;
            for (int i = (int)start; i < end; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        _count++;
                }
                if (_count == 0)
                    _list.Add(i.ToString());
                _count = 0;
            }
            List<string> _answers1 = new List<string>();
            for (int i = 13; i < end; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        _count++;
                }
                if (_count == 0)
                    _answers1.Add(i.ToString());
                _count = 0;
            }
            string _temp = "";
            List<string> _answers = new List<string>();
            for (int i = 0; i < _list.Count; i++)
            {
                for (int j = _list.ElementAt(i).Length; j > 0; j--)
                {
                    _temp += _list.ElementAt(i)[j-1];
                }
                if (_list.Contains(_temp))
                {
                    _answers.Add(_list.ElementAt(i));
                    _answers.Add(_temp);
                }
                if (_answers1.Contains(_temp))
                {
                    _answers.Add(_list.ElementAt(i));
                }
                _temp = "";
            }
            List<int> _sorted = new List<int>();
            foreach (var item in _answers)
            {
                _sorted.Add(int.Parse(item));
            }
            _sorted.Sort();
            _sorted = _sorted.Distinct().ToList();
            string _array = "";
            foreach (var item in _sorted)
            {
                _array += item + " ";
            }
            _array = _array.Trim();
            return _array;
        }
    }
}
