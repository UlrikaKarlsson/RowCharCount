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
            string userInput = "";
            int countLines = 0;
            int countWords = 0;
            int countChar = 0;
            string delimeters = " ";
            string[] wordsInText = null;

            //read file
            Console.Write("Please enter the filename you want to open: ");
            userInput = Console.ReadLine();
            string[] lineInFile = File.ReadAllLines(userInput);
            Console.WriteLine();
            foreach (string line in lineInFile )
            {
                Console.WriteLine(line);
                countLines++;
                wordsInText = line.Split(delimeters.ToCharArray());
                for(int i = 0; i < wordsInText.Length; i++)
                {
                    countWords++;
                }
                foreach (char c in line)
                {
                    countChar++;
                }
            }
            
            Console.WriteLine("\nTotal of lines in text: " + countLines + 
                "     Total of words in text: " + countWords +
                "     Total of chars in text: " + countChar);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
