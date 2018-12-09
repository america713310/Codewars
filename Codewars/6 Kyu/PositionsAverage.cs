using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class PositionsAverage
    {
        public static double PosAverage(string s)
        {
            s = "444996, 699990, 666690, 096904";
            List<string> _list = new List<string>();
            foreach (var item in s.Split(','))
            {
                _list.Add(item.Trim());
            }

            double _count = 0;
            for (int i = 0; i < _list.Count; i++)
            {
                for (int j = i+1; j < _list.Count; j++)
                {
                    for (int k = 0; k < _list[i].Length; k++)
                    {
                        if (_list[i][k] == _list[j][k])
                            _count++;
                    }
                }
            }
            double a = _count;
            double b = _list.Count * _list[0].Length;
            return _count/(_list.Count * _list[0].Length)*100;
        }
    }
}
