using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class ClockInMirror
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            string _answer = "";
            string _hour = timeInMirror.Substring(0, 2);
            string _minute = timeInMirror.Substring(3, 2);
            Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            string[,] _array = new string[12, 2] { { "01", "10" }, { "02", "09" }, { "03", "08" }, { "04", "07" },
            { "05", "06" },{ "06", "05" },{ "07", "04" },{ "08", "03" },{ "09", "02" },{ "10", "01" },{ "11", "12" },{ "12", "11" } };

            for (int i = 0; i < 12; i++)
            {
                _dictionary.Add(_array[i, 0], _array[i, 1]);
            }
            foreach (var el in _dictionary)
            {
                if (_hour == el.Key)
                {
                    if (_minute == "00")
                    {
                        _hour = (int.Parse(el.Value) + 1).ToString();
                        if (_hour.Length == 1)
                        {
                            _hour = "0" + _hour;
                        }
                        break;
                    }
                    else
                    {
                        _hour = el.Value;
                        break;
                    }
                }
            }
            _minute = (60 - int.Parse(_minute)).ToString();
            if (_minute.Length == 1)
                _minute = "0" + _minute;
            if (_minute == "60")
                _minute = "00";
            _answer = _hour + ":" + _minute;
            return _answer;
        }
    }
}
