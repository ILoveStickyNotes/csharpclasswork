using System;

namespace Exercises
{
    public class Conditionals
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>

        static void Main(string[] args)
        {
            var a = new Conditionals();
            var b = new Loops();
            b.Loops5();
        }
        
        public void Exercise1()
        {
            Console.WriteLine("Enter a number from 1-10");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
                Console.WriteLine("Valid Number");
            else
                Console.WriteLine("Invalid");
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2()
        {
            Console.WriteLine("Enter a Number: ");
            var input = Console.ReadLine();
            var a = Convert.ToInt32(input);
            Console.WriteLine("Enter a Number again: ");
            input = Console.ReadLine();
            var b = Convert.ToInt32(input);
            var max = (a > b) ? a : b;

            Console.WriteLine("The Biggest Number is: " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public void Exercise3()
        {
            Console.WriteLine("Width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? Orientation.Landscape : Orientation.Portrait;
            Console.WriteLine("The Orientation is: " + orientation);
        }

        public enum Orientation
        {
            Landscape,
            Portrait
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public void Exercise4()
        {
            Console.WriteLine("Speed Limit?");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed of Car?");
            var car = Convert.ToInt32(Console.ReadLine());

            if (car > limit)
            {
                var demerits = (car - limit) / 5;
                Console.WriteLine("The speeder received " + demerits + " demerits.");
                var suspended = (demerits > 12) ? true : false;
                Console.WriteLine("Suspended: " + suspended);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Car is within the speed limit");
                Console.ReadLine();
            }
        }
    }
}
