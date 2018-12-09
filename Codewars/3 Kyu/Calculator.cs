using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._3_Kyu
{
    class Calculator
    {
        public static double Evaluate(string expression)
        {
            if (expression == null)
                return 0;
            double _answer = 0;
            string _temp = "";
            string _tempForAnswer = "";
            expression = expression.Replace(" ", "");

            List<string> _list = GetList(expression);
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i] == "*")
                {
                    _answer = Convert.ToDouble(_list[i - 1].ToString()) * Convert.ToDouble(_list[i + 1].ToString());
                    _temp += _list[i - 1].ToString() + _list[i].ToString() + _list[i + 1].ToString();
                    _tempForAnswer += _answer.ToString();
                    expression = expression.Replace(_temp, _tempForAnswer);
                    i = 0;
                    _temp = "";
                    _tempForAnswer = "";
                    _list = GetList(expression);
                }
                if (_list[i] == "/")
                {
                    try
                    {
                        _answer = Convert.ToDouble(_list[i - 1].ToString()) / Convert.ToDouble(_list[i + 1].ToString());
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Attempted divide by zero.");
                    }
                    _temp += _list[i - 1].ToString() + _list[i].ToString() + _list[i + 1].ToString();
                    _tempForAnswer += _answer.ToString();
                    expression = expression.Replace(_temp, _tempForAnswer);
                    i = 0;
                    _temp = "";
                    _tempForAnswer = "";
                    _list = GetList(expression);
                }
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if (_list[i] == "+")
                {
                    _answer = Convert.ToDouble(_list[i - 1].ToString()) + Convert.ToDouble(_list[i + 1].ToString());
                    _temp += _list[i - 1].ToString() + _list[i].ToString() + _list[i + 1].ToString();
                    _tempForAnswer += _answer.ToString();
                    expression = expression.Replace(_temp, _tempForAnswer);
                    i = 0;
                    _temp = "";
                    _tempForAnswer = "";
                    _list = GetList(expression);
                }
                if (_list[i] == "-")
                {
                    _answer = Convert.ToDouble(_list[i - 1].ToString()) - Convert.ToDouble(_list[i + 1].ToString());
                    _temp += _list[i - 1].ToString() + _list[i].ToString() + _list[i + 1].ToString();
                    _tempForAnswer += _answer.ToString();
                    expression = expression.Replace(_temp, _tempForAnswer);
                    i = 0;
                    _temp = "";
                    _tempForAnswer = "";
                    _list = GetList(expression);
                }
            }
            _answer = Convert.ToDouble(expression);
            return _answer;
        }

        public static List<string> GetList(string expression)
        {
            string _temp = "";
            List<string> _list = new List<string>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != '*' && expression[i] != '/' && expression[i] != '+' && expression[i] != '-')
                {
                    _temp += expression[i];
                }
                else
                {
                    _list.Add(_temp);
                    _temp = "";
                    _list.Add(expression[i].ToString());
                }
            }
            _list.Add(_temp);
            return _list;
        }
    }
}
