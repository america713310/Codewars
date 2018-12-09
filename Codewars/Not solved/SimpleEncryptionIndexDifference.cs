using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Not_solved
{
    class SimpleEncryptionIndexDifference
    {
        public static string Encrypt(string text)
        {
            int _difference = 0;
            List<char> _list = new List<char>();
            List<int> _list2 = new List<int>();
            List<char> _list3 = new List<char>();
            char[] _array = new char[] { '.', ',', ':', ';', '-', '?', '!', ' ', '\'', '(', ')', '$', '%', '&', '"' };
            char[] _region = new char[77];
            StringBuilder _sb = new StringBuilder(text);
            string _output = "";

            for (int i = 65; i <= 90; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 97; i <= 122; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 48; i <= 57; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 0; i < _array.Length; i++)
            {
                _list.Add(_array[i]);
            }
            for (int i = 0; i < _region.Length; i++)
            {
                _region[i] = _list[i];
            }
            _list.Clear();
            char s = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (char.IsLower(text[i]))
                        _sb[i] = char.ToUpper(text[i]);
                    else if (char.IsUpper(text[i]))
                        _sb[i] = char.ToLower(text[i]);
                }
                else
                    _sb[i] = text[i];
            }
            text = _sb.ToString();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; i < _region.Length; j++)
                {
                    if (text[i] == _region[j])
                    {
                        _list2.Add(j);
                        break;
                    }
                }
            }
            for (int i = 0; i < _list2.Count() - 1; i++)
            {
                if (i == 0)
                {
                    _list.Add(_region[_list2[0]]);
                }
                if (i == _list2.Count() - 1)
                {
                    _difference = _list2[i] - _list2[0];
                }
                else
                {
                    _difference = _list2[i] - _list2[i + 1];
                }
                _list.Add(_region[(_difference + 77) % 77]);
            }
            _list2.Clear();

            for (int i = 0; i < _region.Length; i++)
            {
                if (_list[0] == _region[i])
                {
                    _list3.Add(_region[_region.Length - 1 - i]);
                    break;
                }
            }
            for (int i = 1; i < _list.Count(); i++)
            {
                _list3.Add(_list[i]);
            }
            foreach (var el in _list3)
                _output += el;
            return _output;
        }

        public static string Decrypt(string encryptedText)
        {
            encryptedText = "&61kujla";
            int _difference = 0;
            int _temp = 0;
            List<char> _list = new List<char>();
            List<int> _list2 = new List<int>();
            List<char> _list3 = new List<char>();
            char[] _array = new char[] { '.', ',', ':', ';', '-', '?', '!', ' ', '\'', '(', ')', '$', '%', '&', '"' };
            char[] _region = new char[77];
            StringBuilder _sb = new StringBuilder(encryptedText);
            string _output = "";

            for (int i = 65; i <= 90; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 97; i <= 122; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 48; i <= 57; i++)
            {
                _list.Add((char)i);
            }
            for (int i = 0; i < _array.Length; i++)
            {
                _list.Add(_array[i]);
            }
            for (int i = 0; i < _region.Length; i++)
            {
                _region[i] = _list[i];
            }
            for (int i = 0; i < _region.Length; i++)
            {
                if (encryptedText[0] == _region[i])
                {
                    _list3.Add(_region[_region.Length - 1 - i]);
                    break;
                }
            }
            _list.Clear();
            for (int i = 1; i < encryptedText.Length; i++)
            {
                _list3.Add(encryptedText[i]);
            }
            for (int k = 0; k < _region.Length; k++)
            {
                if (_region[k] == _list3[0])
                    _temp = k;
            }
            for (int i = 0; i < _list3.Count(); i++)
            {
                if (i == 0)
                {
                    _list.Add(_list3[i]);
                }
                if (i == 1)
                {
                    for (int j = 0; j < _region.Length; j++)
                    {
                        if (_list3[i] == _region[j])
                        {
                            _difference = 77 - j + _temp;
                            _list.Add(_region[_difference]);
                            break;
                        }
                    }
                }
                else if (i == _list2.Count() - 1)
                {
                    _difference = _list2[i] - _list2[0];
                }
                else
                {
                    for (int j = 0; j < _region.Length; j++)
                    {
                        if (_list3[i] == _region[j])
                        {
                            //_difference = 77 - j +  ;
                            _list.Add(_region[_difference]);
                            break;
                        }
                    }
                }
            }
            return _output;
        }
    }
}
