using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.CSharp;
using System.Numerics;

namespace Codewars.Not_solved
{
    class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            int[] ways = new int[money + 1];
            ways[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= money; j++)
                {
                    ways[j] += ways[j - coins[i]];
                }
            }
            return ways[money];
        }
    }
}
