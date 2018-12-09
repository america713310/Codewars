using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class BasicCalculator
    {
        public static double Execute(double num1, char op, double num2)
        {
            if (op == '/' && num2 == 0)
            {
                throw new ArgumentException();
            }
            switch (op)
            {
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
