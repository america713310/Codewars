using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class ValidateCreditCardNumber
    {
        public static bool Validate(string n)
        {
            n = n.Replace(" ", "");
            int _unitsCount = 0;
            int _count = 0;
            List<int> _list = new List<int>();

            foreach (char el in n)
            {
                _list.Add(int.Parse(el.ToString()));
            }
            for (int i = n.Length - 1; i > 0; i -= 2)
            {
                _list[i] *= 2;
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (_list[i] > 9)
                {
                    _list[i] = int.Parse(_list[i].ToString()[0].ToString()) + int.Parse(_list[i].ToString()[1].ToString());
                }
                _count += _list[i];
            }
            _unitsCount = (_count * 9).ToString().Length;
            if ((_count + _unitsCount) % 10 == 0)
                return true;
            else return false;
        }
    }
}
