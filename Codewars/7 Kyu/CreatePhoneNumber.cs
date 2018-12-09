using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class CreatePhoneNumber
    {
        public static string GeneratePhoneNumber(int[] numbers)
        {
            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
                numbers[0], numbers[1], numbers[2], numbers[3], numbers[4],
                numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
        }
        public static bool ValidPhoneNumberMethod(string phoneNumber)
        {
            return new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\s\d{3}-\d{4}$").IsMatch(phoneNumber);

            //Regex r = new Regex(@"^\(\d{3}\)\s{1}\d{3}-\d{4}$");
            //Match m = r.Match(phoneNumber);
            //return m.Success;

            //      return (phoneNumber.Length == 14 && phoneNumber == string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
            //phoneNumber[1],
            //phoneNumber[2],
            //phoneNumber[3],
            //phoneNumber[6],
            //phoneNumber[7],
            //phoneNumber[8],
            //phoneNumber[10],
            //phoneNumber[11],
            //phoneNumber[12],
            //phoneNumber[13]) && phoneNumber[0] == '(' && phoneNumber[4] == ')' && phoneNumber[5] == ' ' && phoneNumber[9] == '-');

            //string pattern = @"^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$";
            //return new Regex(pattern).IsMatch(phoneNumber);
        }
    }
}
