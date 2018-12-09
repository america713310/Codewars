using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._7_Kyu
{
    class RemoveFiles
    {
        public static void RemoveMyFiles()
        {
            string path = @"C:\TestFolder";

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".txt"))
                    File.Delete(files[i]);
            }
            Console.WriteLine("Finished!");
        }
    }
}
