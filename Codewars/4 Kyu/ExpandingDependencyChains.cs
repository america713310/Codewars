using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class ExpandingDependencyChains
    {
        public static void ExpandDependencies(Dictionary<string, string[]> dependencies)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            List<string> listKeys = new List<string>();
            List<string> listValues = new List<string>();
            string s = "";

            foreach (var item in dependencies)
            {
                listKeys.Add(item.Key);
                foreach (var el in item.Value)
                {
                    s += el;
                }
                listValues.Add(s);
                s = "";
            }
            for (int i = 0; i < listKeys.Count; i++)
            {
                dictionary.Add(listKeys[i], listValues[i]);
            }
            foreach (var item in dictionary)
            {
                foreach (var el in dictionary)
                {
                    foreach (var element in item.Value)
                    {

                    }
                }
            }
            int a = 0;
        }
    }
}
