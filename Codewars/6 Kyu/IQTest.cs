using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class IQTest
    {
        public static int FindDifferent(string array)
        {
            int _globalItem = 0;

            if (array.Split(' ').Where(x => Convert.ToInt32(x.ToString()) % 2 == 0).Count() == 1)
            {
                for (int i = 0; i < array.Split(' ').Length; i++)
                {
                    if (int.Parse(array.Split(' ')[i].ToString()) % 2 == 0)
                        _globalItem = i + 1;
                }
            }
            else
            {
                for (int i = 0; i < array.Split(' ').Length; i++)
                {
                    if (int.Parse(array.Split(' ')[i].ToString()) % 2 != 0)
                        _globalItem = i + 1;
                }
            }
            return _globalItem;

            //var ints = numbers.Split(' ').Select(int.Parse).ToList();
            //var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
            //return ints.FindIndex(c => c == unique) + 1;
        }
    }
}
