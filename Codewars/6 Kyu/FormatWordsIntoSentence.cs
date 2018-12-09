using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class FormatWordsIntoSentence
    {
        public static string FormatWords(string[] words)
        {
            if (words == null)
                return "";
            string _answer = "";
            List<string> _list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    _list.Add(words[i]);
                }
            }
            
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list.Count == 2)
                {
                    _answer += _list[0] + " and " + _list[1];
                    return _answer;
                }
                else
                {
                    if (i == _list.Count - 2)
                    {
                        _answer += _list[i];
                        _answer += " and ";
                    }
                    else if (i == _list.Count - 1)
                    {
                        _answer += _list[i];
                    }
                    else
                    {
                        _answer += _list[i];
                        _answer += ", ";
                    }
                }
            }
           
            return _answer;
        }
    }
}
