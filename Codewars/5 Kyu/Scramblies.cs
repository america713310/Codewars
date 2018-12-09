using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                map.Add(str1[i], i + 1);
            }
            for (int i = 0; i < str2.Length; i++)
            {
                int count = map.ElementAt(i).Key;
                if (count == 0) return false;
                map.Add(str2[i], --count);
            }
            return true;
        }
    }
}
