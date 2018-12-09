using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class ConsonantValue
    {
        public static int Solve(string s)
        {
            s = s.ToLower();
            char[] _array = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            List<string> _list = new List<string>();
            foreach (var item in s.Split(_array))
            {
                _list.Add(item);
            }
            List<int> _answer = new List<int>();
            int _count = 0;
            Dictionary<string, int> _dictionary = new Dictionary<string, int>();
            string[] _letters = new string[21] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            int[] _values = new int[21] { 2, 3, 4, 6, 7, 8, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26 };
            for (int i = 0; i < 21; i++)
            {
                _dictionary.Add(_letters[i], _values[i]);
            }
            for (int i = 0; i < _list.Count; i++)
            {
                _count = 0;
                foreach (var item in _list[i])
                {
                    foreach (var el in _dictionary)
                    {
                        if (item.ToString() == el.Key)
                        {
                            _count += el.Value;
                            break;
                        }
                    }
                    _answer.Add(_count);
                }
            }
            return _answer.Max();
        }
    }
}
