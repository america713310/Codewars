using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class CheckThreeAndTwo
    {
        public static bool CheckThreeAndTwoMethod(string[] array)
        {
            var gData = array.GroupBy(x => x).Select(x => x.Count()).ToList();
            return (gData.Any(x => x == 3) && gData.Any(x => x == 2));
        }
    }
}
