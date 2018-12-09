using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6_Kyu
{
    class WhichAreIn
    {
        public static string[] GetInArray(string[] array1, string[] array2)
        {
            List<string> _listOfWords = new List<string>();
            List<string> _list = new List<string>();  

            for (int i = 0; i < array1.Length; i++)
            {
                _list.Add(array1[i]);
            }

            for (int i = 0; i < _list.Count; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains(_list.ElementAt(i)))
                    {
                        _listOfWords.Add(_list[i]);
                        _list.Remove(_list.ElementAt(i));
                        i--;
                        break;
                    }
                }
            }

            string[] _answers = new string[_listOfWords.Count];
            for (int i = 0; i < _listOfWords.Count; i++)
            {
                _answers[i] = _listOfWords[i];
            }
            return _answers;
        }
    }
}
