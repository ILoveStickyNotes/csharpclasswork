using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Strings
    {
        public void Strings1()
        {
            Console.WriteLine("Enter nums seperated by hypen");
            var nums = Console.ReadLine();
            var split = nums.Split('-');

            for (var i = 0; i < split.Count() - 1; i++)
            {
                var consecutive = ((Convert.ToInt32(split[i + 1]) - 1) == Convert.ToInt32(split[i])) ? true : false;
                Console.WriteLine(Convert.ToInt32(split[i + 1]));
                if (!consecutive)
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
                Console.WriteLine("Consecutive");
            }

        }

        public void Strings2()
        {
            var intlist = new List<int>();

            Console.WriteLine("Enter numbers separated by a hyphen");

            var input = Console.ReadLine();
            var array = input.Split('-');

            while (true)
            {
                if (!string.IsNullOrWhiteSpace(input))
                {
                    for (var b = 0; b < array.Length; b++)
                    {
                        intlist.Add(Convert.ToInt32(array[b]));
                        Console.WriteLine(intlist[b]);
                    }
                    intlist.Sort();
                    for (var i = 0; i < intlist.Count; i++)
                    {
                        if (intlist[i] == intlist[i + 1])
                        {
                            Console.WriteLine("Duplicate");
                            break;
                        }
                    }
                }
                break;
            }
        }

        public void Strings3()
        {
            Console.WriteLine("Enter a time value in the 24-hour format");
            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var hours = Convert.ToInt32(input.Substring(0, input.IndexOf(':')));
                var minutes = Convert.ToInt32(input.Substring(input.IndexOf(':') + 1));
                var isValid = (hours > 23 || hours < 0 || minutes > 59 || minutes < 0) ? "Invalid Time" : "Ok";

                Console.WriteLine(isValid);
            }
        }

        public void Strings4()
        {
            var pascal = new List<string>();

            Console.WriteLine("Enter some words to be converted");
            var input = Console.ReadLine().ToLower();
            var text = input.Split(' ');
            for (var i = 0; i < text.Length; i++)
            {
                var firstLetter = (text[i]).Substring(0,1).ToUpper();
                var restOfWord = (text[i]).Substring(1);
                var wholeWord = (firstLetter + restOfWord);
                Console.WriteLine(wholeWord);
                pascal.Add(wholeWord);
            }
            
            Console.WriteLine(string.Join("", pascal));
        }

        public void Strings5()
        {
            var vowelCount = 0;
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine().ToLower();
            foreach (var character in input)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount + " Vowels");
        }
    }
}


