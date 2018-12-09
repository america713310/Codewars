using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Not_solved
{
    class SimpleEncryptionAlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            string _first = "", _second = "", _temp = "";
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < text.Length - 1; i += 2)
                {
                    _temp = text[text.Length - 1].ToString();
                    _first += text[i + 1];
                    _second += text[i];
                }
                text = _first + _second + _temp;
                _first = ""; _second = "";
            }
            return text;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            int _value = 0;
            string _first = "", _second = "", _output = "";
            for (int j = 0; j < n; j++)
            {
                _output = ""; _first = ""; _second = "";
                for (int i = 0; i < encryptedText.Length / 2; i++)
                {
                    _first += encryptedText[i];
                    _value = i;
                }
                for (int i = _value + 1; i < encryptedText.Length; i++)
                {
                    _second += encryptedText[i];
                }
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        _output += _second[i / 2];
                    }
                    else
                    {
                        _output += _first[i / 2];
                    }
                }
                encryptedText = _output;
            }
            return _output;
        }
    }
}
