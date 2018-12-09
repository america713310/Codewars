using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class LetsPlayDarts
    {
        public static string GetScore(double x, double y)
        {
            string num = "";

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) >= 340 / 2)
            {
                return "X";
            }
            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 12.70 / 2)
            {
                return "DB";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 31.8 / 2)
            {
                return "SB";
            }

            num = getRightNum(x, y);

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 324 / 2)
            {
                return "D" + num;
            }
            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 198 / 2 && Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 214 / 2)
            {
                return "T" + num;
            }
            return num;
        }

        private static string getRightNum(double x, double y)
        {
            int[] Felder = new int[] { 3, 19, 7, 16, 8, 11, 14, 9, 12, 5, 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3 };
            var alpha = Math.Atan2(x, y) / Math.PI * 180;
            alpha += 180 + 9;
            var index = (int)(alpha / 18);
            return Felder[index].ToString();
        }
    }
}
