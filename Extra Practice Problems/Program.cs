﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise one. Create a program that has the user type two intergers. 
            //Determine if those intergers are equal or inequal, then have the program inform the use if the intergeres are equal or not.
            //Complete!

            //Console.WriteLine("Type out an interger");
            //int intOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Type out another interger. This interger can be the same as the first, or it may be a separate interger.");
            //int intTwo = int.Parse(Console.ReadLine());

            //if (intOne == intTwo)
            //{
            //    Console.WriteLine("Those intergers are equal to one another!");
            //}
            //else
            //{
            //    Console.WriteLine("Those intergers aren't equal to one another!");
            //}


            //Exercise two. Design app that asks for the user to input a number. Have app tell the user if that number is even or odd
            //Exercise Complete!
            //Console.WriteLine("Please input any interger");
            //int number =int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}


            //Exersice three. Create a program that asks the user to input a positive or negative interger.
            // Make the program accurately tell the user if the interger they entered is positive or negative.
            //Complete!

            //Console.WriteLine("Write a positive or negative interger!");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 0)
            //{
            //    Console.WriteLine("That is a positive number!");
            //}

            //else
            //{
            //    Console.WriteLine("That is a negative number!");
            //}



            //Homework exercise four
            // Allow the user to type a single alphebetical character. 
            // Make the program accurately tell the user if the character is a vowel or consenant.
            //Complete!

            //Console.WriteLine("Type a single alphabetical character");
            //char letter = char.Parse(Console.ReadLine());
            //switch (letter)
            //{
            //    case 'a':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'e':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'i':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'o':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'u':
            //        Console.WriteLine("That is a vowel!");
            //        break;

            //    case 'y':
            //        Console.WriteLine("That is (sometimes?) a vowel!");
            //        break;

            //    default:
            //        Console.WriteLine("That is a consenant!");
            //        break;
            //}

            //Exercise five. Design app to ask the user for three separate intergers. 
            // Have program recognize which of the three is the greatest interger.
            //Exercise complete!

            //Console.WriteLine("Enter three intergers");
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());
            //int thirdNumber = int.Parse(Console.ReadLine());

            //if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            //{
            //    Console.WriteLine(firstNumber + " is the greates interger!");
            //}
            //else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            //{
            //    Console.WriteLine(secondNumber + " is the greatest interger!");
            //}
            //else
            //{
            //    Console.WriteLine(thirdNumber + " is the greatest interger!");
            //}


            //Exercise six.Write a Console application that asks the user for 4 integers.
            //Calculate the mean for these 4 numbers and display the result.
            //Exercise complete!

            Console.WriteLine("Please write in four separate intergers");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            double preMean = (firstNumber + secondNumber + thirdNumber + fourthNumber);
            double mean = (preMean / 4);

            Console.WriteLine(mean);
        }
    }
}
