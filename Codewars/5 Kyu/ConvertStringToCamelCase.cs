using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            string[] _words = str.Split(new char[] { '-', '_' });

            StringBuilder sb = new StringBuilder(_words[0]);
            for (int i = 1; i < _words.Length; i++)
                sb.Append(_words[i].Substring(0, 1).ToUpper()).Append(_words[i].Substring(1));
            return sb.ToString();
        }
    }
}
