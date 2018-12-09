using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class CartesianNeighborsDistance
    {
        public static double[] CartesianNeighborsDistanceMethod(int x, int y, int range)
        {
            List<double[]> _list = new List<double[]>();
            List<double> _list2 = new List<double>();
            List<double> _list3 = new List<double>();

            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    _list.Add(new double[] { i, j });
                }
            }
            foreach (var item in _list)
            {
                _list2.Add(Math.Round(Math.Pow(Math.Pow(range - item[0], 2) + Math.Pow(range - item[1], 2), 0.5), 2));
            }
            for (int i = 0; i < range; i++)
            {
                _list2.Add(range - i);
            }
            foreach (var item in _list2)
            {
                foreach (var el in _list3)
                {
                    if (item == el)
                    {
                        _list3.Remove(el);
                        break;
                    }
                }
                _list3.Add(item);
            }
            double[] _answers = new double[_list3.Count];

            for (int i = 0; i < _answers.Length; i++)
            {
                _answers[i] = _list3[i];
            }
            return _answers;
        }
    }
}
