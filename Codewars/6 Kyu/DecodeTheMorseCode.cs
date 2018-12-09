using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class DecodeTheMorseCode
    {
        public static string Decode(string morseCode)
        {
            morseCode = morseCode.Trim();

            int _count = 0;
            string _temp = "";
            string _answer = "";
            List<string> _list = new List<string>();
            Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            string[] _values = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "SOS", ".", "!" };
            string[] _keys = new string[] { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
            "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "...---...", ".-.-.-", "-.-.--" };

            for (int i = 0; i < 39; i++)
            {
                _dictionary.Add(_keys[i], _values[i]);
            }
            for (int i = 0; i < morseCode.Length; i++)
            {
                if (morseCode[i].ToString() == " ")
                {
                    if (_count == 0)
                    {
                        _list.Add(_temp);
                        _temp = "";
                        _count++;
                    }
                    else
                    {
                        _count++;
                    }
                }
                else
                {
                    if (_count == 3)
                        _list.Add(" ");
                    _temp += morseCode[i].ToString();
                    _count = 0;
                }
            }
            if (_temp != "")
                _list.Add(_temp);

            for (int i = 0; i < _list.Count; i++)
            {
                if (_list.ElementAt(i) == " ")
                    _answer += " ";
                for (int j = 0; j < 39; j++)
                {
                    if (_dictionary.ElementAt(j).Key == _list.ElementAt(i))
                    {
                        _answer += _dictionary.ElementAt(j).Value;
                        break;
                    }
                }
            }
            return _answer;
        }
    }
}
