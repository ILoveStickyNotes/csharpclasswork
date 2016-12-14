using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Files
    {
        public void Files1()
        {
            var wordCount = 0;
            var words = File.ReadAllText(@"C:/Users/BuiM1/Desktop/Call Notes.txt").Split(' ');
            foreach (var word in words)
            {
                wordCount++;
            }
            Console.WriteLine("Words: " + wordCount);
        }

        public void Files2()
        {
            var longest = 0;
            var longestWord = "";
            var words = File.ReadAllText(@"C:/Users/BuiM1/Desktop/Call Notes.txt").Split(' ');
            foreach (var word in words)
            {
                if (word.Length > longest)
                {
                    longest = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest word is: " + longestWord + "\nWith " + longest + " characters.");
        }
    }

}
