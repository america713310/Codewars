using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class CreditCardIssuerChecking
    {
        public static string GetIssuer(long number)
        {
            if (number.ToString().Length == 13)
                if (number.ToString().StartsWith("4"))
                    return "VISA";
            if (number.ToString().Length == 15)
                if (number.ToString().StartsWith("34") || number.ToString().StartsWith("37"))
                    return "AMEX";
            if (number.ToString().Length == 16)
            {
                if (number.ToString().StartsWith("51") || number.ToString().StartsWith("52") ||
                    number.ToString().StartsWith("53") || number.ToString().StartsWith("54") ||
                    number.ToString().StartsWith("55"))
                    return "Mastercard";
                if (number.ToString().StartsWith("4"))
                    return "VISA";
                if (number.ToString().StartsWith("6011"))
                    return "Discover";
            }
            return "Unknown";
        }
        //static string[] MCStart = "51 52 53 54 55".Split();
        //public static string getIssuer(long number)
        //{
        //    var s = number.ToString();
        //    if (s.StartsWith("6011") && s.Length == 16) return "Discover";
        //    if (s.StartsWith("4") && (s.Length == 13 || s.Length == 16)) return "VISA";
        //    if (MCStart.Any(x => s.StartsWith(x)) && s.Length == 16) return "Mastercard";
        //    if ((s.StartsWith("34") || s.StartsWith("37")) && s.Length == 15) return "AMEX";
        //    return "Unknown";
        //}
    }
}
