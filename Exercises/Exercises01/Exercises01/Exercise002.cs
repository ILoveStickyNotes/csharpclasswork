using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Loops
    {


        public void Loops1()
        {
            int counter = 0;
            {
                for (var i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(i + " Is not evenly divisible by 3");
                    }
                }
                Console.WriteLine("Program was able to divide evenly " + counter + " times.");
            }
        }


        public void Loops2()
        {

            int sum = 0;

            while (true)
            {
                Console.WriteLine("Type in a number, or ok to exit.");
                var a = Console.ReadLine();
                if (a != "ok")
                {
                    sum += Convert.ToInt32(a);
                }
                else
                {
                    Console.WriteLine("The numbers you entered combined are: " + sum);
                    break;
                } 
                
            }
        }


        public void Loops3()
        {
            Console.WriteLine("Enter a number you want to get the factorial of: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var factorial = a;

            for (var i = 1; i < a; i++)
            {
               factorial *= i;
            }
            Console.WriteLine("The Factorial of " + a + "! " + factorial);
        }

        public void Loops4()
        {
            var random = new Random();
            var secretnum = random.Next(1, 10);
            const int chances = 4;

            Console.WriteLine("Can you guess the secret number?");
            for (int i = 0; i < chances; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                var isCorrect = (secretnum == input) ? true : false;
                if (isCorrect)
                {
                    Console.WriteLine("Wow you guessed it");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Guess");
                }
            }

            Console.WriteLine("The Number was " + secretnum);
        }


        public void Loops5()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma ex. 1,2,3,4");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max = " + max);

        }
    }
}
