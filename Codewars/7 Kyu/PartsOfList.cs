using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class PartsOfList
    {
        public static string[][] Partlist(string[] arr)
        {
            string[][] _temp = new string[arr.Length - 1][];

            _temp = Enumerable.Range(0, arr.Length - 1)
                         .Select(x =>
                             new string[]{
                                 string.Join("", arr.Take(x + 1)),
                                 string.Join("", arr.Skip(x + 1).Take(arr.Length-x))
                               }).ToArray();

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    _temp[i] = new string[] { string.Join(" ", arr.Take(i + 1)), string.Join(" ", arr.Skip(i + 1).Take(arr.Length - i)) };
            //}
            return _temp;
        }
    }
}
