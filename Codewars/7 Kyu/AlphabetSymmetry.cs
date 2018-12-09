using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class AlphabetSymmetry
    {
        public static IEnumerable<int> Solve(List<string> arr)
        {
            int _count = 0;
            char[] _alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            List<int> _list = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (char.Parse(arr[i][j].ToString().ToLower()) == _alphabet[j])
                        _count++;
                }
                _list.Add(_count);
                _count = 0;
            }
            return _list;

            //public static List<int> Solve(List<string> arr) =>
            //arr.Select(v => v.Where((c, i) => Char.ToLower(c) - 97 == i).Count()).ToList();
        }
    }
}
