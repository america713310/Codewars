using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class HumanReadableDurationFormat
    {
        public static string FormatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            Dictionary<string, int> _dictionaryValues = new Dictionary<string, int>();
            Dictionary<string, int> _dictionary = new Dictionary<string, int>();
            string _answer = "";

            int _years = seconds / 31536000;
            seconds = seconds % 31536000;
            int _days = seconds / 86400;
            seconds = seconds % 86400;
            int _hours = seconds / 3600;
            seconds = seconds % 3600;
            int _minutes = seconds / 60;
            seconds = seconds % 60;
            _dictionaryValues.Add("years", _years);
            _dictionaryValues.Add("days", _days);
            _dictionaryValues.Add("hours", _hours);
            _dictionaryValues.Add("minutes", _minutes);
            _dictionaryValues.Add("seconds", seconds);
            for (int i = 0; i < _dictionaryValues.Values.Count; i++)
            {
                if (_dictionaryValues.ElementAt(i).Value == 0)
                {
                    _dictionaryValues.Remove(_dictionaryValues.ElementAt(i).Key); i--;
                }
            }
            for (int i = 0; i < _dictionaryValues.Count; i++)
                _dictionary.Add(_dictionaryValues.ElementAt(i).Value == 1 ? _dictionaryValues.ElementAt(i).Key.Substring(0, _dictionaryValues.ElementAt(i).Key.ToString().Length - 1) : _dictionaryValues.ElementAt(i).Key, _dictionaryValues.ElementAt(i).Value);
            for (int i = 0; i < _dictionary.Count; i++)
            {
                if (_dictionary.Count == 2)
                {
                    _answer += _dictionary.ElementAt(0).Value + " " + _dictionary.ElementAt(0).Key.ToString() + " and " + _dictionary.ElementAt(1).Value + " " + _dictionary.ElementAt(1).Key.ToString();
                    return _answer;
                }
                else
                    _answer = i == _dictionary.Count - 2 ? _answer += _dictionary.ElementAt(i).Value + " " + _dictionary.ElementAt(i).Key.ToString() + " and " : i == _dictionary.Count - 1 ? _answer += _dictionary.ElementAt(i).Value + " " + _dictionary.ElementAt(i).Key.ToString() : _answer += _dictionary.ElementAt(i).Value + " " + _dictionary.ElementAt(i).Key.ToString() + ", ";
            }
            return _answer;
        }
    }
}
