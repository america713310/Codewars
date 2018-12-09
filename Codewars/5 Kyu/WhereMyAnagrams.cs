using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class WhereMyAnagrams
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var pattern = word.OrderBy(p => p).ToArray();
            return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
        }
    }
}
