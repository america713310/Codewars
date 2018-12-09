using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> _dictionary = new Dictionary<char, int>();
            int _count = 0;
            bool _continue = false;

            foreach (var item in str)
            {
                _continue = false;
                foreach (var el in _dictionary)
                {
                    if (item == el.Key)
                    {
                        _count = el.Value;
                        _dictionary.Remove(el.Key);
                        _dictionary.Add(item, _count + 1);
                        _continue = true;
                        break;
                    }
                }
                if (!_continue)
                    _dictionary.Add(item, 1);
            }
            return _dictionary;

            // return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
