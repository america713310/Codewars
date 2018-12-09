using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class CartesianNeighbors
    {
        public static IEnumerable<int[]> CartesianNeighbor(int x, int y)
        {
            List<int[]> _list = new List<int[]>();
            _list.Add(new int[] { x - 1, y - 1 });
            _list.Add(new int[] { x - 1, y });
            _list.Add(new int[] { x - 1, y + 1 });
            _list.Add(new int[] { x, y - 1 });
            _list.Add(new int[] { x, y + 1 });
            _list.Add(new int[] { x + 1, y - 1 });
            _list.Add(new int[] { x + 1, y });
            _list.Add(new int[] { x + 1, y + 1 });
            return _list;

            // return Enumerable.Range(x - 1, 3).SelectMany(xn => Enumerable.Range(y - 1, 3).Where(yn => xn != x || yn != y).Select(yn => new[] { xn, yn }));
        }
    }
}
