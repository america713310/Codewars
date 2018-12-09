using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class RomanNumeralsEncoder
    {
        public static string Solution(int n)
        {
            string _answer = "";
            string[] _array = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", };

            for (int i = 0; i < n / 1000; i++)
                _answer += "M";
            n = n % 1000;
            if (n >= 900)
                _answer += "CM";
            else if (n >= 500 && n < 900)
            {
                _answer += "D";
                for (int i = 0; i < n % 500 / 100; i++)
                    _answer += "C";
            }
            else if (n < 500 && n >= 400)
                _answer += "CD";
            else if (n < 400 && n >= 100)
                for (int i = 0; i < n / 100; i++)
                    _answer += "C";
            n = n % 100;
            if (n >= 90)
                _answer += "XC";
            else if (n < 90 && n >= 50)
            {
                _answer += "L";
                for (int i = 0; i < n % 50 / 10; i++)
                    _answer += "X";
            }
            else if (n < 50 && n >= 40)
                _answer += "XL";
            else if (n >= 10 && n < 40)
                for (int i = 0; i < n / 10; i++)
                    _answer += "X";
            n = n % 10;
            if (n == 0)
                return _answer;
            _answer += _array[n - 1];
            return _answer; 
        }
    }
}
