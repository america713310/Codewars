using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            return (long.Parse(a) + long.Parse(b)).ToString();
        }
    }
}
