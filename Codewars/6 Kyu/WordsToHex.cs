using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class WordsToHex
    {
        public static string[] WordsToHexMethod(string words)
        {
            string _answer = "";
            foreach (string item in words.Split(' '))
            {
                _answer += "#";
                foreach (var el in item.Take(3))
                {
                    _answer += BitConverter.ToString(new byte[] { Convert.ToByte(el) });
                }
                _answer += " ";
            }
            _answer = _answer.Trim();
            List<string> _list = new List<string>();
            foreach (var item in _answer.Split(' '))
            {
                _list.Add(item);
            }
            for (int i = 0; i < _answer.Split(' ').Length; i++)
            {
                if (_answer.Split()[i].Length == 3)
                    _answer.Split()[i] += "0000";
                if (_answer.Split()[i].Length == 5)
                    _answer.Split()[i] += "00";
            }
            List<string> _list2 = new List<string>();
            Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            _dictionary.Add("A", "a");
            _dictionary.Add("B", "b");
            _dictionary.Add("C", "c");
            _dictionary.Add("D", "d");
            _dictionary.Add("E", "e");
            _dictionary.Add("F", "f");
            _dictionary.Add("G", "g");
            _dictionary.Add("H", "h");
            _dictionary.Add("I", "i");
            _dictionary.Add("J", "j");
            _dictionary.Add("K", "k");
            _dictionary.Add("L", "l");
            _dictionary.Add("M", "m");
            _dictionary.Add("N", "n");
            _dictionary.Add("O", "o");
            _dictionary.Add("P", "p");
            _dictionary.Add("Q", "q");
            _dictionary.Add("R", "r");
            _dictionary.Add("S", "s");
            _dictionary.Add("T", "t");
            _dictionary.Add("U", "u");
            _dictionary.Add("V", "v");
            _dictionary.Add("W", "w");
            _dictionary.Add("X", "x");
            _dictionary.Add("Y", "y");
            _dictionary.Add("Z", "z");
            int count = 0;
            for (int i = 0; i < _answer.Length; i++)
            {
                count = 0;
                foreach (var item in _dictionary)
                {
                    if (_answer[i].ToString() == item.Key)
                    {
                        _list2.Add(item.Value);
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    _list2.Add(_answer[i].ToString());
            }
            _answer = "";
            foreach (var item in _list2)
            {
                _answer += item;
            }
            string[] s = new string[_answer.Split(' ').Length];
            for (int i = 0; i < _answer.Split(' ').Length; i++)
            {
                s[i] += _answer.Split(' ')[i];
                if (s[i].Length == 3)
                {
                    s[i] = s[i].Trim();
                    s[i] += "0000";
                }
                if (s[i].Length == 5)
                {
                    s[i] = s[i].Trim();
                    s[i] += "00";
                }
            }
            return s;
        }
    }
}
