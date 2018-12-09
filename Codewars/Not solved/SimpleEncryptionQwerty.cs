using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Not_solved
{
    class SimpleEncryptionQwerty
    {
        public static string Encrypt(string text, int key)
        {
            int _firstDigit = 0, _secondDigit = 0, _thirdDigit = 0;
            string _output = "";
            char _temp = ' ';
            char[] _firstLine = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] _secondLine = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] _thirdLine = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.' };
            _firstDigit = int.Parse(key.ToString()[0].ToString());
            _secondDigit = int.Parse(key.ToString()[1].ToString());
            _thirdDigit = int.Parse(key.ToString()[2].ToString());

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    _output += ' ';
                if (char.IsUpper(text[i]))
                {
                    _temp = char.ToLower(text[i]);
                    if (_firstLine.Contains(_temp))
                    {
                        for (int j = 0; j < _firstLine.Length; j++)
                        {
                            if (_firstLine[j] == _temp)
                            {
                                _output += char.ToUpper(_firstLine[(j + _firstDigit) % _firstLine.Length]);
                                break;
                            }
                        }
                    }
                    if (_secondLine.Contains(_temp))
                    {
                        for (int j = 0; j < _secondLine.Length; j++)
                        {
                            if (_secondLine[j] == _temp)
                            {
                                _output += char.ToUpper(_secondLine[(j + _secondDigit) % _secondLine.Length]);
                                break;
                            }
                        }
                    }
                    if (_thirdLine.Contains(_temp))
                    {
                        for (int j = 0; j < _thirdLine.Length; j++)
                        {
                            if (_thirdLine[j] == _temp)
                            {
                                _output += char.ToUpper(_thirdLine[(j + _thirdDigit) % _thirdLine.Length]);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (_firstLine.Contains(text[i]))
                    {
                        for (int j = 0; j < _firstLine.Length; j++)
                        {
                            if (_firstLine[j] == text[i])
                            {
                                _output += _firstLine[(j + _firstDigit) % _firstLine.Length];
                                break;
                            }
                        }
                    }
                    if (_secondLine.Contains(text[i]))
                    {
                        for (int j = 0; j < _secondLine.Length; j++)
                        {
                            if (_secondLine[j] == text[i])
                            {
                                _output += _secondLine[(j + _secondDigit) % _secondLine.Length];
                                break;
                            }
                        }
                    }
                    if (_thirdLine.Contains(text[i]))
                    {
                        for (int j = 0; j < _thirdLine.Length; j++)
                        {
                            if (_thirdLine[j] == text[i])
                            {
                                _output += _thirdLine[(j + _thirdDigit) % _thirdLine.Length];
                                break;
                            }
                        }
                    }
                }
            }
            return _output;
        }

        public static string Decrypt(string encryptedText, int key)
        {
            int _firstDigit = 0, _secondDigit = 0, _thirdDigit = 0;
            string _output = "";
            char _temp = ' ';
            char[] _firstLine = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] _secondLine = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] _thirdLine = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.' };
            _firstDigit = int.Parse(key.ToString()[0].ToString());
            _secondDigit = int.Parse(key.ToString()[1].ToString());
            _thirdDigit = int.Parse(key.ToString()[2].ToString());
            for (int i = 0; i < encryptedText.Length; i++)
            {
                if (encryptedText[i] == ' ')
                    _output += ' ';
                if (char.IsUpper(encryptedText[i]))
                {
                    _temp = char.ToLower(encryptedText[i]);
                    if (_firstLine.Contains(_temp))
                    {
                        for (int j = 0; j < _firstLine.Length; j++)
                        {
                            if (_firstLine[j] == _temp)
                            {
                                if (j >= _firstDigit)
                                {
                                    _output += char.ToUpper(_firstLine[j - _firstDigit]);
                                }
                                else
                                {
                                    _output += char.ToUpper(_firstLine[_firstLine.Length + (j - _firstDigit)]);
                                }
                            }
                        }
                    }
                    if (_secondLine.Contains(_temp))
                    {
                        for (int j = 0; j < _secondLine.Length; j++)
                        {
                            if (_secondLine[j] == _temp)
                            {
                                if (j >= _secondDigit)
                                {
                                    _output += char.ToUpper(_secondLine[j - _secondDigit]);
                                }
                                else
                                {
                                    _output += char.ToUpper(_secondLine[_secondLine.Length + (j - _secondDigit)]);
                                }
                                break;
                            }
                        }
                    }
                    if (_thirdLine.Contains(_temp))
                    {
                        for (int j = 0; j < _thirdLine.Length; j++)
                        {
                            if (_thirdLine[j] == _temp)
                            {
                                if (j >= _thirdDigit)
                                {
                                    _output += char.ToUpper(_thirdLine[j - _thirdDigit]);
                                }
                                else
                                {
                                    _output += char.ToUpper(_thirdLine[_thirdLine.Length + (j - _thirdDigit)]);
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (_firstLine.Contains(encryptedText[i]))
                    {
                        for (int j = 0; j < _firstLine.Length; j++)
                        {
                            if (_firstLine[j] == encryptedText[i])
                            {
                                if (j >= _firstDigit)
                                {
                                    _output += _firstLine[j - _firstDigit];
                                }
                                else
                                {
                                    _output += _firstLine[_firstLine.Length + (j - _firstDigit)];
                                }
                                break;
                            }
                        }
                    }
                    if (_secondLine.Contains(encryptedText[i]))
                    {
                        for (int j = 0; j < _secondLine.Length; j++)
                        {
                            if (_secondLine[j] == encryptedText[i])
                            {
                                if (j >= _secondDigit)
                                {
                                    _output += _secondLine[j - _secondDigit];
                                }
                                else
                                {
                                    _output += _secondLine[_secondLine.Length + (j - _secondDigit)];
                                }
                                break;
                            }
                        }
                    }
                    if (_thirdLine.Contains(encryptedText[i]))
                    {
                        for (int j = 0; j < _thirdLine.Length; j++)
                        {
                            if (_thirdLine[j] == encryptedText[i])
                            {
                                if (j >= _thirdDigit)
                                {
                                    _output += _thirdLine[j - _thirdDigit];
                                }
                                else
                                {
                                    _output += _thirdLine[_thirdLine.Length + (j - _thirdDigit)];
                                }
                                break;
                            }
                        }
                    }
                }
            }
            return _output;
        }
    }
}
