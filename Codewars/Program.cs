using Codewars._4_Kyu;
using Codewars._5_Kyu;
using Codewars._6_Kyu;
using Codewars._7_Kyu;
using Codewars.Not_solved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in IsMyFriendCheating.RemovNb(100))
            {
                foreach (var el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(PositionsAverage.PosAverage("s"));
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B", "D" };
            startFiles["B"] = new string[] { "C" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { };
            // Assert
            ExpandingDependencyChains.ExpandDependencies(startFiles);
        }
    }
}
