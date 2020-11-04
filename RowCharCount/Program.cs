using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowCharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string path = @"c:\FileForSwedishLanguage.txt";
            string[] linesOfFileText = File.ReadAllLines(path);
            //read file
            foreach (string s in linesOfFileText)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
